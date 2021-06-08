using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class OverloadExample
    {
        private string _name;
        private string _city;
        private int _number;

        public OverloadExample(
            string name, 
            string city, 
            int number)
        {
            _number = number;
            _city = city;
            _name = name;
        }

        public OverloadExample(
            string csvLine)
        //: this(
        //    ExtractName(csvLine), 
        //    ExtractCity(csvLine), 
        //    ExtractNumber(csvLine))
        {
            // eks: "Per,Oslo,345"
            //var strings = csvLine.Split(',');
            //_name = strings[0];
            //_city = strings[1];
            //_number = Convert.ToInt32(strings[2]);
        }
    }
}
