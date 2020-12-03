using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestService.Models;

namespace RestService.Controllers
{
    public class ListItemsController : ApiController
    {
        private static List<Persons> ListPersons { get; set; } = new List<Persons>();
        // GET api/<controller>

   
        public IEnumerable<Persons> Get()
        {
            return ListPersons;
        }

        // GET api/<controller>/5

        public HttpResponseMessage Get(int id)
        {
            var item = ListPersons.FirstOrDefault(x => x.id == id);
            if (item != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, item);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Get(string name, int birthYear, string town, bool matchCase, bool letterCaseSensitivity)
        {
            var tempList = ListPersons;

            if (!string.IsNullOrEmpty(name))
            {
                tempList = GetByName(tempList, name, matchCase, letterCaseSensitivity).ToList();
            }

            if (birthYear.ToString().Length >= 2 && birthYear.ToString().Length <= 4 && birthYear != -1)
            {
                tempList = GetByBirthYear(tempList, birthYear).ToList();
            }

            if (!string.IsNullOrEmpty(town))
            {
                tempList = GetByTown(tempList, town, matchCase, letterCaseSensitivity).ToList();
            }

            return Request.CreateResponse(HttpStatusCode.OK, tempList);

        }
       
        private IEnumerable<Persons> GetByName(List<Persons> personList, string name,
                bool matchCase,
                bool letterCaseSensitivity)
        {
            if (matchCase)
            {
                if (letterCaseSensitivity)
                {
                    return personList
                        .Where(person => person.name == name);
                }

                return personList
                    .Where(person => person.name.ToLower() == name.ToLower());
            }

            if (letterCaseSensitivity)
            {
                return personList
                   .Where(person => person.name.Contains(name));
            }

            return personList
                .Where(person => person.name.ToLower().Contains(name.ToLower()));
        }

        private IEnumerable<Persons> GetByBirthYear(List<Persons> personList, int query)
        {
            return personList
                .Where(person => person.year == query);
        }

        private IEnumerable<Persons> GetByTown(List<Persons> personList, string town,
          bool matchCase,
          bool letterCaseSensitivity)
        {
            if (matchCase)
            {
                if (letterCaseSensitivity)
                {
                    return personList
                        .Where(person => person.city == town);
                }

                return personList
                    .Where(person => person.city.ToLower() == town.ToLower());
            }

            if (letterCaseSensitivity)
            {
                return personList
                   .Where(person => person.city.Contains(town));
            }

            return personList
                .Where(person => person.city.ToLower().Contains(town.ToLower()));
        }


        // POST api/<controller>
        public HttpResponseMessage Post([FromBody] Persons model)
        {
            if (string.IsNullOrEmpty(model?.name) || string.IsNullOrEmpty(model?.surname))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var maxId = 0;

            if (ListPersons.Count > 0)
            {
                maxId = ListPersons.Max(x => x.id);
            }
            model.id = maxId + 1;
            ListPersons.Add(model);
            return Request.CreateResponse(HttpStatusCode.Created, model);
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody] Persons model)
        {
            if (string.IsNullOrEmpty(model?.name) || string.IsNullOrEmpty(model?.surname))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var item = ListPersons.FirstOrDefault(x => x.id == id);

            if (item != null)
            {
                // Update *all* of the item's properties
                item.name = model.name;
                item.surname = model.surname;
                item.city = model.city;
                item.year = model.year;

                item.pet.animal = model.pet.animal;
                item.pet.name = model.pet.name;
                item.pet.year = model.pet.year;

                item.car.theCarBrand = model.car.theCarBrand;
                item.car.color = model.car.color;
                item.car.year = model.car.year;
                item.car.mileage = model.car.mileage;

                return Request.CreateResponse(HttpStatusCode.OK, item);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            var item = ListPersons.FirstOrDefault(x => x.id == id);
            if (item != null)
            {
                ListPersons.Remove(item);
                return Request.CreateResponse(HttpStatusCode.OK, item);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}