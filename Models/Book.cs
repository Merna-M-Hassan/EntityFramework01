using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24_EF_Core.Models
{

    //Model - POCO = Plain Old C# Object - Entity - Domain Entity
    public class Book
    {
        //search for integral property [int, long, short]
        //not any numerical property, must its name be Id, or entity name followed by ID [nameId]
        //once it is found, it recognizes as the PK.
        //by default any chosen integral property as PK, auto generated identity constraint (1, 1)
        //if no integral property found, it will search for string or GUID property.   GUID = Global Universal Id
        //No identity constraint will be added if string or GUID found.
        public int Id { get;  set; }    //primary key

        //nullable reference type (accepts/allow null)
        //will be in DB nvarchar(max) --> any string in a convention way is nvarchar(max)
        //change from nullable to non nullable column.
        public string Title { get; set; }

        //Non Nullable value type (not allow null)
        //mapped in SQL as decimal(18,2) 
        public decimal Price { get; set; }

        public int PageNumber { get; set; }

        public DateTime Year { get; set; }

        //Non Nullable value type
        //mapped as int in SQL
        public int Quantity {  get; set; }
    }
}
