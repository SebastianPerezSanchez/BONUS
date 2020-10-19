using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BonusF.Models
{

    public class BonusC {


            public Int16 dni { get; set;}

            public String Name { get; set;}

            public String Lastname {get; set;}

            public String District {get; set;}
            
            [Display(Name="Banco")]
            public String Bank {get; set;}

             public List<SelectListItem> Banks { get; } = new List<SelectListItem>
            {
            new SelectListItem { Value = "BN", Text = "Banco de la Nacion" },
            new SelectListItem { Value = "BCP", Text = "Banco de Credito del Peru" },
            new SelectListItem { Value = "BBVA", Text = "BBVA"  },
            new SelectListItem { Value = "S", Text = "Scotiabank"  },
            new SelectListItem { Value = "I", Text = "Interbank"  },
            new SelectListItem { Value = "CS", Text = "CrediScotia"  },
            new SelectListItem { Value = "FC", Text = "Financiera Confianza"  },
            new SelectListItem { Value = "CRLA", Text = "Caja Rural Los Andes"  },
            new SelectListItem { Value = "CDS", Text = "Caja de Santa"  },
            new SelectListItem { Value = "CR", Text = "Caja Raiz"  },
            };


            public Int16 Age {get; set;}

            [Display(Name="Género")] 
            public String Gender {get; set;}

            [NotMapped]
            public String Response { get; set; }




    }

}