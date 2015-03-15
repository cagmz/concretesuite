using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteSuite
{
     class JobSite
     {
          private List<Concrete> site;

          public JobSite()
          {
               site = new List<Concrete>();
          }

          public JobSite(Concrete concreteObj)
          {
               site = new List<Concrete>();
               site.Add(concreteObj);
          }

          public Boolean addConcrete(Concrete obj)
          {
               if(obj != null)
               {
                    site.Add(obj);
                    return true;
               } else return false;
                    
          }

          public void removeConcrete(int index)
          {
               // Prevent out of bounds selection
               if (this.site.Count <= index && index >= 0)
               {
                    this.site.RemoveAt(index);
               }
          }

          public List<Concrete> getList()
          {
               return this.site;
          }

          public void displayList()
          {
               //foreach (Concrete tempConcrete in this.site)
               //{

               //}
          }

     }
}