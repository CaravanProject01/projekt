using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravans.model
{
    public class TableArticle
    {
        private string Id;
        private string Name;
        private int Price;
        private int Production;
        private int Requisition;

        public TableArticle(string Id, string Name, int Price, int Production, int Requisition)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Production = Production;
            this.Requisition = Requisition;
        }

        //GETs

        public string GetId()
        {
            return this.Id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetPrice()
        {
            return this.Price;
        }

        public int GetProduction()
        {
            return this.Production;
        }

        public int GetRequisition()
        {
            return this.Requisition;
        }

        //SETs

        public void SetId(string Id)
        {
            this.Id = Id;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetPrice(int Price)
        {
            this.Price = Price;
        }
        public void SetProduction(int Production)
        {
            this.Production = Production;
        }

        public void SetRequisition(int Requisition)
        {
            this.Requisition = Requisition;
        }

        /*
        //Update DB

        internal void UpdateDB()//(string Id, string Name, string Price, string Production, string Requisition)
        {
            //string Comm = "UPDATE Article SET Price='" + this.GetPrice() + "' Prod='" + this.GetProduction() + "' Requisition='" + this.GetRequisition() + "' WHERE Name='" + this.GetName() +"'";
            string Comm = String.Format//("UPDATE Users SET Name='{0}' WHERE Age={1}", name, age);
            ("UPDATE [dbo].[Article] SET [Name]='{0}', [Price]={1}, [Prod]={2}, [Requisition]={3} WHERE [IdArticle]='{4}'", this.GetName(), this.GetPrice(), this.GetProduction(), this.GetRequisition(), this.GetId());
            Console.WriteLine("{0}", Comm);
            //Console.WriteLine("{0}", this.GetProduction());
            SQLreq Connect = new SQLreq();
            Connect.UpdateArticle(Comm);
        }*/
    }
}
