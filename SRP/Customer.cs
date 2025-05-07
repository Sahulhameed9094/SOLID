using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /*
     * have mulltiple responsibilty inside this class
     * issue we have face in future tightly coupled
     * hard to upgrade 
     * **/

    /**❌ Violations of SRP:
     * tightly Coupled its have two responistibity 
     * 1. data model
     * 2. Data presistance or business logic model
     * 
     * **/

    /*---------------------------------------PROBLEM---------------------------------------*/
    /*public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }


        public void Add(Customer customer)
        {

        }

        public List<Customer> GetAll()
        {
            return new List<Customer>();
        }
    }*/

    /*convert into srp princible
        • This principle states that a class should have one and only one responsibility.
        • There should not be more than one reason for a class to change.
        • SRP makes the classes compact and neat where each one is responsible for a single problem, task, or concern.
     */
    /*---------------------------------------SOLUTION---------------------------------------*/
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
    public class CustomerService
    {
        public void Add(Customer customer)
        {
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>();
        }
    }

    /*---------------------------------------PROBLEM---------------------------------------*/
    /* public class Invoice
     {
         public int Id { get; set; }
         public double Amount { get; set; }

         public void CalculateTax()
         {
             // Tax calculation logic
         }

         public void PrintInvoice()
         {
             // Printing logic
         }

         public void SaveToDatabase()
         {
             // DB save logic
         }
     }*/

    /*---------------------------------------Solution---------------------------------------*/
    public class Invoice
    {
        public int Id { get; set; }
        public double Amount { get; set; }

    }

    class CalculationService
    {
        public void CalculateTax()
        {
            // Tax calculation logic
        }

    }

    class PrintService
    {
        public void PrintInvoice()
        {
            // Printing logic
        }
    }

    class InvoceReposirty
    {
        public void SaveToDatabase()
        {
            // DB save logic
        }

    }




    /*---------------------------------------PROBLEM---------------------------------------*/
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }



    }

    class FileSaver
    {
        public void SaveToFile()
        {
            // Code to save file
        }
    }

    public class ReportGenrater
    {
        public void GeneratePDF(Report report)
        {
            // Code to generate PDF
        }

    }

    public class MailService
    {
        public void EmailReport(string email, Report report)
        {
            // Code to send report via email
        }
    }


}
