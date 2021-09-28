using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PetShop;
using PetShop.Classes;

namespace PetShop.Classes
{
    public class Cep
    {
        public class Unit
        {
            public String cep { get; set; }
            public String logradouro { get; set; }
            public String complemento { get; set; }
            public String bairro  {get; set;}
            public String localidade  {get; set;}
            public String uf  {get; set;}
            public String unidade  {get; set;}
            public String ibge  {get; set;}
            public String gia  {get; set;}
        }

        public static Unit DesSerializedClassUnit(string vJsason)
        {
            return JsonConvert.DeserializeObject<Unit>(vJsason);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
