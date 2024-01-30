﻿using Alura.ByteBank.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.Infraestrutura.Testes
{
    public class ByteBantkContextoTestes
    {
        [Fact]
        public void TestaConexaoContextoComBDMySql()
        {
            // Arrange
            var contexto = new ByteBankContexto();
            bool conectado;

            // Act
            try
            {
                conectado = contexto.Database.CanConnect();
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possível conectar a base de dados.");
            }

            // Assert
            Assert.True(conectado);
        }
    }
}
