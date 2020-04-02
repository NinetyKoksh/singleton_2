using System;
using System.Collections.Generic;

namespace SingletonUniversity
{
    public class Database
    {
        private static Guid _guid;
        private static Database _dbInstance;
       
        private Database() { }
        
        public   List <Student> Students{ get; set; }
        public  List <Subject> Subjects { get; set; }
        public List <Teacher> Teachers { get; set; }

        public Guid Guid { get { return _guid; } }

        public static Database GetInstance()
         
        {
            if (_dbInstance == null)
                _dbInstance = new Database();
           _guid = Guid.NewGuid();
            return _dbInstance;
         }
        
        

    }
}
