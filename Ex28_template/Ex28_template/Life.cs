using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public string Name
        {
            get { return _name; }
        }
        public Life(DateTime bd ,string n, float  w, float h, float d,float we):base(n,w,h,d,we)
        {
            this._birthDay = bd;
            this._name = n;
        }
        public bool GetBirthDay()
        {
            if (birthday.Date == DateTime.Today.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
