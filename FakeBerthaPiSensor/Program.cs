using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeBerthaPiSensor
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpSender = new UdpClient(0) { EnableBroadcast = true };
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 7000);
            //udpSender.Connect(endPoint);
            Console.WriteLine("Broadcast ready. Get started Press Enter");
            Console.ReadLine();
            while (true)
            {
                RandomRecordGenerator _rand = new RandomRecordGenerator();

                double _long = _rand.GetLong();
                double _lat = _rand.GetLat();
                double _bpSystolic = _rand.GetSystolic();
                double _bpDiastolic = _rand.GetDiastolic();
                double _bodyTemperature = _rand.GetTemperature();
                int _heartBeatPerSecond = _rand.GetHeartBeat();
                double _dust = _rand.GetDust();
                double _sulphur = _rand.GetSulphur();
                double _nitrogen = _rand.GetNitrogen();
                double _fluor = _rand.GetFluor();
                double _carbonMonoxide = _rand.GetCarbonMonoxide();
                double _ozone = _rand.GetOzone();
                int _userId = _rand.GetUserId();

                string sensorData = $"long:{_long}\n lat: {_lat}\n bpsystolic:{_bpSystolic}\n bpdiastolic: {_bpDiastolic}\n bodytemperature:{_bodyTemperature}\n heartbeatpersecond:{_heartBeatPerSecond}\n dust:{_dust}\n sulphur:{_sulphur}\n nitrogen:{_nitrogen}\n fluor:{_fluor}\n carbonmonoxide:{_carbonMonoxide}\n ozone:{_ozone}\n userid:{_userId}\n";

                Byte[] sendBytes = Encoding.ASCII.GetBytes(sensorData);

                try
                {
                    udpSender.Send(sendBytes, sendBytes.Length, endPoint);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("UserId:" + _userId);
                Console.WriteLine("Long:" + _long);
                Console.WriteLine("Lat:" + _lat);
                Console.WriteLine("Broadcasting data on Port no: 7000");
                Thread.Sleep(2000);
            }
        }
    }
}
