using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication.Model;
using WebApplication.Model.Context;
using WebApplication.Repository.Implementations;

namespace WebApplication.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        // private MySQLContext _context;
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public object Interlecked { get; private set; }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long? id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

    }
}
