using System;

namespace PropertiesExample
{
    public class Student
    {
        //public int Id;
        //public string Name;
        //public int PassMark = 35;
        private int _id;
        private string _name;
        private int _passMark = 35;

        //Auto properties
        public string Email { get; set; }
        public string City { get; set; }

        //public void SetId (int Id)
        //{
        //    if(Id <= 0)
        //    {
        //        throw new Exception("Student Id can not be negetive");
        //    }
        //    this._id = Id;
        //}

        //public int GetId()
        //{
        //    return this._id;
        //}

        //id get set another example

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id can not be negetive");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }


        //public void SetName(String Name)
        //{
        //    if (string.IsNullOrEmpty(Name))
        //    {
        //        throw new Exception("Name can not be null or empty");
        //    }
        //    this._name = Name;
        //}


        //public string GetName()
        //{
        //    return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        //    //if (string.IsNullOrEmpty(this._name))
        //    //{
        //    //    return "No Name";
        //    //}
        //    //else
        //    //{
        //    //    return this._name;
        //    //}
        //}

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name Can not be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        //public int GetPassMark()
        //{
        //    return this._passMark;
        //}
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
    }
}
