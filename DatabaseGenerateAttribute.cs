using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDD_cars.Data
{
    internal class DatabaseGenerateAttribute : Attribute
    {
        private DatabaseGeneratedOption identity;

        public DatabaseGenerateAttribute(DatabaseGeneratedOption identity)
        {
            this.identity = identity;
        }
    }
}