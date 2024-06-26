using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace MIS.Helpers
{
    public class ReportService
    {
        private readonly string _baseUrl;

        public ReportService()
        {
            _baseUrl = "http://" + FG.Url + ":5000";
        }

        public async Task OpenReportInBrowserAsync(int documento, string tipo)
        {
            string url = $"{_baseUrl}/Reportes/GenerateReport?documento={documento}&tipo={tipo}";
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (!response.IsSuccessStatusCode)
                    {
                        FG.ShowError($"Error al conectar con la URL: {response.ReasonPhrase}", "Error");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    FG.ShowError($"Error al conectar con la URL: {ex.Message}", "Error");
                    return;
                }
            }
            try
            {
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                FG.ShowError($"Error al abrir la URL en el navegador: {ex.Message}", "Error");
            }
        }


    }

}
