using System.Collections;

namespace SuportesBalanceados
{
    public class Colchete
    {
        public static string ValidaColchetes(string s)
        {
            Stack pilha = new Stack();
            char[] txt;
            txt = s.ToCharArray();

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '(' || txt[i] == '[' || txt[i] == '{' || txt[i] == ')' || txt[i] == ']' || txt[i] == '}')
                {
                    pilha.Push(txt[i]);
                }
            }

            if (pilha.Count % 2 != 0) return "Colchetes não correspondentes";

            Stack aux = new Stack();
            bool removeu;

            while (pilha.Count > 0)
            {
                removeu = false;

                if (aux.Count == 0)
                {
                    aux.Push(pilha.Pop());
                }

                if (pilha.Count > 0 && (
                    (pilha.Peek().ToString() == "{" && aux.Peek().ToString() == "}") ||
                    (pilha.Peek().ToString() == "[" && aux.Peek().ToString() == "]") ||
                    (pilha.Peek().ToString() == "(" && aux.Peek().ToString() == ")"))
                    )
                {
                    aux.Pop();
                    pilha.Pop();
                    removeu = true;

                    if (pilha.Count == 0 && aux.Count == 0) return "Colchetes correspondentes";
                }

                if (!removeu) aux.Push(pilha.Pop());
            }

            return "Colchetes não correspondentes";
        }
    }
}
