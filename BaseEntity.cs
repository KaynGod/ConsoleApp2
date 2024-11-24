using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }

        protected BaseEntity(int id)
        {
            Id = id;
            CreatedDate = DateTime.Now;
        }
    }

