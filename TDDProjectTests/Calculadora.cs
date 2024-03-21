using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProjectTests
{
    public class Calculadora
    {
        private List<string> _historico {  get; set; } = [];
        private string _data;
        public Calculadora(string data, List<string> historico) { 
            this._data = data;
            this._historico = historico;
        }
        private void ImprimeHistorico(int val1, int val2,string sinal,int res) 
        { 
            _historico.Add($"{_data} -> {val1} {sinal} {val2} = {res}");
        }

        public int somar(int val1,int val2)
        {
            int res = val1 + val2;
            ImprimeHistorico(val1,val2,"+",res);
            return res;
        }
        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            ImprimeHistorico(val1, val2, "-", res);
            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            ImprimeHistorico(val1, val2, "*", res);
            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            ImprimeHistorico(val1, val2, "/", res);
            return res;
        }
        public List<string> Pegarhistorico()
        {
            return _historico;
        }
    }
}
