using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MIS.Helpers
{
    public class ComPortSimulator
    {
        private CancellationTokenSource _cancellationTokenSource;
        private string _simulatedPortName;
        private int _baudRate;


        public void Start(string portName, int baudRate)
        {
            _simulatedPortName = portName;
            _baudRate = baudRate;

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            Task.Run(() => WriteConstantValueAsync(token), token);
        }

        private async Task WriteConstantValueAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine($"[{_simulatedPortName}] Sent: 254.00");
                await Task.Delay(1000); // Esperar 1 segundo antes de enviar el próximo valor
            }
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }

    }

}
