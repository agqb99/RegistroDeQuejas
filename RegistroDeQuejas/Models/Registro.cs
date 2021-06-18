using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroDeQuejas.Models
{
    public class Registro
    {
        [Key]
        public int RegistroId { get; set; }

        [Required(ErrorMessage = "Insert Name")]
        [Display(Name = "Nombre")]
        [StringLength(70,ErrorMessage = "Can not contain more than 70 characters")]
        [MinLength(2,ErrorMessage = "Can not contain less than 2 characters")]
        public string RegistroName { get; set; }

        /*****************************************************************************/

        [DataType(DataType.DateTime,ErrorMessage = "Select a valid date")]
        [Required(ErrorMessage = "Insert a valid date")]
        [StringLength(20, ErrorMessage = "Can not contain more than 20 characters")]
      //  [MinLength(17, ErrorMessage = "Can not contain less than 17 characters")]
        public string RegistroDate { get; set; }

        /*****************************************************************************/


        [Required(ErrorMessage = "Insert a real dni value (without spaces)")]
        [StringLength(13, ErrorMessage = "Can not contain more than 13 characters")]
        [MinLength(13, ErrorMessage = "Can not contain less than 13 characters")]

        public string RegistroDni { get; set; }

        /*****************************************************************************/


        [Required(ErrorMessage = "Insert a real number value (without spaces)")]
        [StringLength(8, ErrorMessage = "Can not contain more than 8 characters")]
        [MinLength(8, ErrorMessage = "Can not contain less than 8 characters")]

        public string RegistroNum { get; set; }

        /*****************************************************************************/


        //        [DataType(DataType.DateTime, ErrorMessage = "Select a valid copy")]
        // [Required(ErrorMessage = "Insert a valid copy info")]
        [StringLength(20, ErrorMessage = "Can not contain more than 20 characters")]
        public string RegistroCopy { get; set; }

        /*****************************************************************************/

        [Required(ErrorMessage = "Insert a real dependency")]
        [StringLength(30, ErrorMessage = "Can not contain more than 30 characters")]
        [MinLength(10, ErrorMessage = "Can not contain less than 10 characters")]


        public string RegistroDependency { get; set; }

        /*****************************************************************************/

        [Required(ErrorMessage = "Insert a real position")]
        [StringLength(50, ErrorMessage = "Can not contain more than 50 characters")]
        [MinLength(2, ErrorMessage = "Can not contain less than 2 characters")]

        public string RegistroPosition { get; set; }

        /*****************************************************************************/

        [DataType(DataType.EmailAddress, ErrorMessage = "Insert a valid email address")]
        [Required(ErrorMessage = "Insert a email")]
        [StringLength(30, ErrorMessage = "Can not contain more than 30 characters")]
        [MinLength(10, ErrorMessage = "Can not contain less than 10 characters")]

        public string RegistroEmail { get; set; }
        /*****************************************************************************/

       // allow nulls
        [StringLength(80, ErrorMessage = "Can not contain more than 80 characters")]
        [MinLength(10, ErrorMessage = "Can not contain less than 10 characters")]
        public string RegistroComplaints { get; set; }

        /*****************************************************************************/


        [StringLength(100, ErrorMessage = "Can not contain more than 100 characters")]
       // [MinLength(10, ErrorMessage = "Can not contain less than 20 characters")]
        public string RegistroRelation { get; set; }




        /*****************************************************************************/
   
        [StringLength(100, ErrorMessage = "Can not contain more than 100 characters")]

        public string RegistroEvidence { get; set; }
        /*****************************************************************************/


       
        
         
         
   

    }
}



