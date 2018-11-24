using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBerthaPiSensor
{
    public class RandomRecordGenerator
    {
        private Random _longRandom;
        private Random _latRandom;
        private Random _bpSystolicRandom;
        private Random _bpDiastolicRandom;
        private Random _bodyTemperatureRandom;
        private Random _heartBeatPerSecondRandom;
        private Random _dustRandom;
        private Random _sulphurRandom;
        private Random _nitrogenRandom;
        private Random _fluorRandom;
        private Random _carbonMonoxideRandom;
        private Random _ozoneRandom;
        private Random _userIdRandom;

        public RandomRecordGenerator()
        {
            _longRandom = new Random();
            _latRandom = new Random();
            _bpSystolicRandom = new Random();
            _bpDiastolicRandom = new Random();
            _bodyTemperatureRandom = new Random();
            _heartBeatPerSecondRandom = new Random();
            _dustRandom = new Random();
            _sulphurRandom = new Random();
            _nitrogenRandom = new Random();
            _fluorRandom = new Random();
            _carbonMonoxideRandom = new Random();
            _ozoneRandom = new Random();
            _userIdRandom = new Random();
        }

        public double GetLong()
        {
            int _longBase = _longRandom.Next(1332450, 1406441);
            double _longTail = _longRandom.NextDouble();
            double _long = _longBase + _longTail;
            return _long;
        }

        public double GetLat()
        {
            int _latBase = _latRandom.Next(7481656, 7574603);
            double _latTail = _latRandom.NextDouble();
            double _lat = _latBase + _latTail;
            return _lat;
        }

        public double GetSystolic()
        {
            return _bpSystolicRandom.Next(95, 140);
        }

        public double GetDiastolic()
        {
            return _bpDiastolicRandom.Next(50, 85);
        }

        public double GetTemperature ()
        {
            return _bodyTemperatureRandom.Next(36, 37);
        }
        public int GetHeartBeat()
        {
            return _heartBeatPerSecondRandom.Next(60, 100);
        }

        public double GetDust()
        {
            return _dustRandom.Next(100);
        }

        public double GetSulphur()
        {
            return _sulphurRandom.NextDouble();
        }

        public double GetNitrogen()
        {
            return _nitrogenRandom.Next(10, 100);
        }

        public double GetFluor()
        {
            return _fluorRandom.Next(1, 10);
        }

        public double GetCarbonMonoxide()
        {
            return _carbonMonoxideRandom.Next(10, 200);
        }

        public double GetOzone()
        {
            return _ozoneRandom.Next(15, 90);
        }

        public int GetUserId ()
        {
            return _userIdRandom.Next(1, 5);
        }
    }
}
