using GerenciamentoMecanica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GerenciamentoMecanica.UnitTests.Core.Entities
{
    public class ClientTests
    {
        [Fact]
        public void Testar_Se_Cliente_Atualiza()
        {
            var client = new Client(
                "Bruno Ferreira",
                "bruno@email.com",
                1,
                "33256985231"
                );

            client.ClientUpdate("Bruno Roberto Olympio Ferreira", "bruno123@email.com");

            Assert.Equal("Bruno Roberto Olympio Ferreira", client.FullName);
            Assert.Equal("bruno123@email.com", client.Email);
        }
    }
}
