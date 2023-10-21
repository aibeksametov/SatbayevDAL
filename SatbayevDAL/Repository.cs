using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatbayevDAL
{
    public class Repository
    {
        
        public bool CreateQuiestions(QuestionTemplate question)
        {
            try
            {
                using (var db = new LiteDatabase(" "))
                {
                    var col = db.GetCollection<QuestionTemplate>("Questions");
                    col.Insert(question);
                    
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdateQuestions(QuestionTemplate question)
        {
            try
            {
                using(var db = new LiteDatabase(" "))
                {
                    var col = db.GetCollection<QuestionTemplate>(" ");
                    col.Update(question);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteQuestions(QuestionTemplate question)
        {
            try
            {
                using (var db = new LiteDatabase(" "))
                {

                }

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
