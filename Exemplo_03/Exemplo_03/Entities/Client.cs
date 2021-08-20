using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_03.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public long Cpf { get; set; }


        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return (Cpf.Equals(other.Cpf) && Email.Equals(other.Email));
        }

        public override int GetHashCode()
        {
            return Cpf.GetHashCode()
                + Email.GetHashCode();
        }
    }
}
