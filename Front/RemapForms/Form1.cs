using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RemapForms
{
    public partial class Form1 : Form
    {
        public class Cliente
        {
            public string cdUserId { get; set; }
            public double cdCpf { get; set; }
            public string dsNome { get; set; }
            public double cdTelefone { get; set; }
            public string dsEndereco { get; set; }
            public string dsEstado { get; set; }
            public string dsCidade { get; set; }
            public DateTime dtRegistro { get; set; }
        }
        public class Vento
        {
            public int cdVentoId;
            public int cdUserId;
            public int cdItensidade;
            public DateTime dtVentoRegistroInicio;
            public DateTime dtVentoRegistroFim;
        }
        public class Solar
        {
            public int cdSolarId;
            public int cdUserId;
            public int cdItensidade;
            public DateTime dtSolarRegistroInicio;
            public DateTime dtSolarRegistroFim;
        }

        public int totalItens = 0;

        public List<Cliente> usuarios = null;
        public List<Vento> ventos = null;
        public List<Solar> solares = null;
        public Form1()
        {
            InitializeComponent();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58181/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/usuario/CarregarUsuarios").Result;
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                TextBox01.Text += response.Content.ReadAsStringAsync().Result.ToString();
                TextBox01.Text += Environment.NewLine;
            }
            else
            {
                TextBox01.Text = "erro carregando usuarios";
                TextBox01.Text += Environment.NewLine;
            }
            response = client.GetAsync("api/medicaoSolar/CarregarMedicaoSolars").Result;
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                TextBox01.Text += response.Content.ReadAsStringAsync().Result.ToString();
                TextBox01.Text += Environment.NewLine;
            }
            else
            {
                TextBox01.Text += "erro carregando solar";
                TextBox01.Text += Environment.NewLine;
            }
            response = client.GetAsync("api/medicaoVento/CarregarMedicaoVentos").Result;
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                TextBox01.Text += response.Content.ReadAsStringAsync().Result.ToString();
                TextBox01.Text += Environment.NewLine;
            }
            else
            {
                TextBox01.Text += "erro carregando vento";
                TextBox01.Text += Environment.NewLine;
            }

            response = client.GetAsync("api/usuario/ConsultarUsuarios").Result;
            usuarios = JsonConvert.DeserializeObject<List<Cliente>>(response.Content.ReadAsStringAsync().Result);
            foreach (Cliente textoItem in usuarios)
            {
                comboBox1.Items.Add(textoItem.cdUserId);
                totalItens++;
            }

            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                comboBox1.ResetText();
            }

            if (comboBox1.Items.Count > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox01.Clear();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58181/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/usuario/ConsultarUsuarios").Result;
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                usuarios = JsonConvert.DeserializeObject<List<Cliente>>(response.Content.ReadAsStringAsync().Result);
                foreach (Cliente textoItem in usuarios)
                {
                    TextBox01.Text += "Usuário Código: " + textoItem.cdUserId.ToString() + ", nome: " + textoItem.dsNome.ToString();
                    TextBox01.Text += Environment.NewLine;
                }

            }
            else
            {
                TextBox01.Text += "erro ler usuarios";
                TextBox01.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex >= 0)
            {
                TextBox01.Clear();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58181/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/medicaoVento/ConsultarMedicaoVentoPorCodigo/" + comboBox1.SelectedItem.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {//pegando o cabeçalho
                    Uri usuarioUri = response.Headers.Location;
                    //Pegando os dados do Rest e armazenando na variável usuários
                    //ventos = JsonConvert.DeserializeObject<List<Vento>>(response.Content.ReadAsStringAsync().Result);

                    ventos = JsonConvert.DeserializeObject<List<Vento>>(response.Content.ReadAsStringAsync().Result);
                    foreach (Vento textoItem in ventos)
                    {
                        TextBox01.Text += "Usuário Código: " + textoItem.cdUserId.ToString() + ", medição: " + textoItem.cdItensidade.ToString();
                        TextBox01.Text += Environment.NewLine;
                    }

                }
                else
                {
                    TextBox01.Text += "erro ler usuarios";
                    TextBox01.Text += Environment.NewLine;
                }
            }
            else
            {
                TextBox01.ResetText();
                TextBox01.Text = "favor selecionar um item valido";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex >= 0)
            {
                TextBox01.Clear();
                if (comboBox1.SelectedIndex >= 0)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:58181/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("api/medicaoSolar/ConsultarMedicaoSolarPorCodigo/" + comboBox1.SelectedItem.ToString()).Result;
                    if (response.IsSuccessStatusCode)
                    {//pegando o cabeçalho
                        Uri usuarioUri = response.Headers.Location;
                        //Pegando os dados do Rest e armazenando na variável usuários
                        //ventos = JsonConvert.DeserializeObject<List<Vento>>(response.Content.ReadAsStringAsync().Result);

                        solares = JsonConvert.DeserializeObject<List<Solar>>(response.Content.ReadAsStringAsync().Result);
                        foreach (Solar textoItem in solares)
                        {
                            TextBox01.Text += "Usuário Código: " + textoItem.cdUserId.ToString() + ", medição: " + textoItem.cdItensidade.ToString();
                            TextBox01.Text += Environment.NewLine;
                        }

                    }
                    else
                    {
                        TextBox01.Text += "erro ler usuarios";
                        TextBox01.Text += Environment.NewLine;
                    }
                }
            }
            else
            {
                TextBox01.ResetText();
                TextBox01.Text = "favor selecionar um item valido";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex >= 0)
            {
                TextBox01.Clear();
                if (comboBox1.SelectedIndex >= 0)
                {
                    foreach (var item in usuarios)
                    {
                        if (comboBox1.SelectedIndex >= 0)
                        {
                            if (item.cdUserId == comboBox1.SelectedItem.ToString())
                            {
                                TextBox01.Text += "Usuário ID: " + item.cdUserId + ",\r\n cpf: " + item.cdCpf + ",\r\n nome: " + item.dsNome + ",\r\n telefone: " + item.cdTelefone + ",\r\n endereço: " + item.dsEndereco + ",\r\n estado: " + item.dsEstado + ",\r\n cidade: " + item.dsCidade + ",\r\n registrado em : " + item.dtRegistro;
                                TextBox01.Text += Environment.NewLine;
                            }
                        }
                        else
                        {
                            TextBox01.Text = "Favor selecionar usuario valido";
                        }
                    }
                }
            }
            else
            {
                TextBox01.ResetText();
                TextBox01.Text = "favor selecionar um item valido";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                TextBox01.Clear();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:58181/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                System.Net.Http.HttpResponseMessage response = client.DeleteAsync("api/usuario/ExcluirUsuario/" + comboBox1.SelectedItem.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {//pegando o cabeçalho
                    Uri usuarioUri = response.Headers.Location;
                    //Pegando os dados do Rest e armazenando na variável usuários
                    TextBox01.Text += response.Content.ReadAsStringAsync().Result.ToString();
                    TextBox01.Text += Environment.NewLine;
                    comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
                    try
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        comboBox1.ResetText();
                    }
                    if(comboBox1.Items.Count==0)
                    {
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                    }
                }
                else
                {
                    TextBox01.Text = "erro carregando usuarios";
                    TextBox01.Text += Environment.NewLine;
                }
            }
            else
            {
                TextBox01.ResetText();
                TextBox01.Text = "favor selecionar um item valido";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (NomeBox.Text.Trim().Length > 0)
            {
                if (CPFBox.Text.Trim().Length > 0)
                {
                    if (TelefoneBox.Text.Trim().Length > 0)
                    {
                        if (EnderecoBox.Text.Trim().Length > 0)
                        {
                            if (EstadoBox.Text.Trim().Length > 0)
                            {
                                if (CidadeBox.Text.Trim().Length > 0)
                                {
                                    Cliente clienteCadastrado = new Cliente();
                                    Vento ventoCadastrado = new Vento();
                                    Solar solarCadastrado = new Solar();
                                    clienteCadastrado.cdUserId = (totalItens + 1).ToString();
                                    clienteCadastrado.dsNome = NomeBox.Text.ToString().Trim();
                                    clienteCadastrado.cdCpf = Convert.ToDouble(CPFBox.Text.Trim());
                                    clienteCadastrado.cdTelefone = Convert.ToDouble(TelefoneBox.Text.Trim());
                                    clienteCadastrado.dsEndereco = EnderecoBox.Text.ToString().Trim();
                                    clienteCadastrado.dsEstado = EstadoBox.Text.ToString().Trim();
                                    clienteCadastrado.dsCidade = CidadeBox.Text.ToString().Trim();
                                    clienteCadastrado.dtRegistro = DateTime.Now;
                                    var stringContent = JsonConvert.SerializeObject(clienteCadastrado);
                                    var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
                                    ventoCadastrado.cdVentoId = (totalItens * totalItens + 1);
                                    ventoCadastrado.cdUserId = (totalItens + 1);
                                    ventoCadastrado.cdItensidade = totalItens * 100;
                                    ventoCadastrado.dtVentoRegistroInicio = DateTime.Now;
                                    ventoCadastrado.dtVentoRegistroFim = DateTime.Now;
                                    solarCadastrado.cdSolarId = (totalItens * totalItens + 1);
                                    solarCadastrado.cdUserId = (totalItens + 1);
                                    solarCadastrado.cdItensidade = totalItens * 55;
                                    solarCadastrado.dtSolarRegistroInicio = DateTime.Now;
                                    solarCadastrado.dtSolarRegistroFim = DateTime.Now;
                                    var stringContentVento = JsonConvert.SerializeObject(ventoCadastrado);
                                    var dataVento = new StringContent(stringContentVento, Encoding.UTF8, "application/json");
                                    var stringContentSolar = JsonConvert.SerializeObject(solarCadastrado);
                                    var dataSolar = new StringContent(stringContentSolar, Encoding.UTF8, "application/json");
                                    TextBox01.Clear();
                                    HttpClient client = new HttpClient();
                                    client.BaseAddress = new Uri("http://localhost:58181/");
                                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                                    HttpResponseMessage response = client.PostAsync("api/usuario/CadastrarUsuario", data).Result;
                                    HttpResponseMessage response2 = client.PostAsync("api/medicaoVento/CadastrarMedicaoVento", dataVento).Result;
                                    HttpResponseMessage response3 = client.PostAsync("api/medicaoSolar/CadastrarMedicaoSolar", dataSolar).Result;
                                    if (response.IsSuccessStatusCode)
                                    {//pegando o cabeçalho
                                        Uri usuarioUri = response.Headers.Location;
                                        //Pegando os dados do Rest e armazenando na variável usuários
                                        TextBox01.Text += response.Content.ReadAsStringAsync().Result.ToString().Trim();
                                        TextBox01.Text += Environment.NewLine;

                                        usuarios.Add(clienteCadastrado);

                                        comboBox1.Items.Add(clienteCadastrado.cdUserId);
                                        totalItens++;

                                        if (comboBox1.Items.Count > 0)
                                        {
                                            button1.Enabled = true;
                                            button2.Enabled = true;
                                            button3.Enabled = true;
                                            button4.Enabled = true;
                                            button5.Enabled = true;
                                        }
                                    }
                                    else
                                    {
                                        TextBox01.Text = "erro carregando usuarios";
                                        TextBox01.Text += Environment.NewLine;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Favor colocar uma cidade válida");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Favor colocar um estado válido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor colocar um endereço válido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor colocar um Telefone válido");
                    }
                }
                else
                {
                    MessageBox.Show("Favor colocar um CPF válido");
                }
            }
            else
            {
                MessageBox.Show("Favor colocar um nome válido");
            }
        }

    }
}
