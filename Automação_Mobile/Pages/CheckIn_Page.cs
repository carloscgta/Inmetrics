using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Mobile.Pages
{
  public  class CheckIn : Base
    {
        string androidCheckinLink = "//android.widget.TextView[@text='Check-in]";
        string androidLocalizadorDropdownList = "//android.widget.TextView[@text='Buscar por']";
        string androidLocalizador = "//android.widget.TextView[@text='Localizador']";
        string androidCodigoInput = "//android.widget.TextView[@text='Buscar por']//following-sibling::input";
        string androidSobrenomeInput = "//android.widget.TextView[@text='Sobrenome']";
        
          //logar na aplicação
          //Dados necessário:
          //Login e senha do usuário
          //Email e Telefone
         
        string androidTelefoneInput  = "//android.widget.TextView[@text='Telefone']";
   
        string androidEmailInput = "//android.widget.TextView[@text='Email']";

        public void fazerCheckIn()
        {
            clicar(By.XPath(androidCheckinLink));
        }

        public void selecionarLocalizador()
        {
            clicar(By.XPath(androidLocalizadorDropdownList));
            clicar(By.XPath(androidLocalizador));
            
        }

        public void InserirCodigo(String texto)
        {
            clicar(By.XPath(androidCodigoInput));
            preencherTexto(By.XPath(androidCodigoInput), texto);
        }
        
        public void InserirSobrenome(String texto)
        {
            clicar(By.XPath(androidSobrenomeInput));
            preencherTexto(By.XPath(androidSobrenomeInput), texto);
        }


    }
}
