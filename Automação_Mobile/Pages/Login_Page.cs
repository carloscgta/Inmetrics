using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Mobile.Pages
{
    class Login : Base
    {
        string botao_login = "//android.widget.TextView[@text='Login']";
        string campo_email = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.EditText";
        string botao_continuar = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup";
        // string status_voo = "//android.widget.TextView[@text='Status de voo']";
        string campo_senha = "";
        public void selecionar_botao_login()
        {
            clicar(By.XPath(botao_login));
        }

        public void preencher_usuario(string texto)
        {
            clicar(By.XPath(campo_email));
            preencherTexto(By.XPath(campo_email), texto);

        }

        public void clicar_continuar()
        {
            clicar(By.XPath(botao_continuar));
        }

        public void preencher_senha(string texto)
        {
            clicar(By.XPath(campo_senha));
            preencherTexto(By.XPath(campo_email), texto);
        }

    }


}