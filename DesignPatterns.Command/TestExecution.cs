using DesignPatterns.Common;
using System;

namespace DesignPatterns.Command
{
    public class TestExecution : ITestExecute
    {
        public void Execute()

        {
            TestUtils.ClearTests();

            TestUtils.AddTest(Test1);
            TestUtils.AddTest(Test2);
            TestUtils.AddTest(Test3);
            TestUtils.AddTest(Test4);
            TestUtils.AddTest(Test5);
            TestUtils.AddTest(Test6);

            TestUtils.ExecuteTests();
        }

        private void Test3()
        {
          

            RemoteControl rc = new RemoteControl(8);
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor1 = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");

            OnCommand<Light> livingRoomLightOn = new OnCommand<Light>(livingRoomLight);
            OffCommand<Light> livingRoomLightOff = new OffCommand<Light>(livingRoomLight);

            OnCommand<Light> kitchenLightOnCommand = new OnCommand<Light>(kitchenLight);
            OffCommand<Light> kitchenLightOffCommand = new OffCommand<Light>(kitchenLight);

           CeilingFanHighCommand ceilingFanOnCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor1);
            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor1);

            StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            OffCommand<Stereo> stereoOffCommand = new OffCommand<Stereo>(stereo);


            rc.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            rc.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
            rc.SetCommand(2, ceilingFanOnCommand, ceilingFanOffCommand);
            rc.SetCommand(3, garageDoorOpenCommand, garageDoorCloseCommand);
            rc.SetCommand(4, stereoOnWithCDCommand, stereoOffCommand);


            Console.Write(rc);

            rc.OnButtonWasPushed(0);
            rc.OffButtonWasPushed(0);
            rc.OnButtonWasPushed(1);
            rc.OffButtonWasPushed(1);
            rc.OnButtonWasPushed(2);
            rc.OffButtonWasPushed(2);
            rc.OnButtonWasPushed(3);
            rc.OffButtonWasPushed(3);
            rc.OnButtonWasPushed(4);
            rc.OffButtonWasPushed(4);
            rc.OnButtonWasPushed(5);
            rc.OffButtonWasPushed(5);
            rc.OnButtonWasPushed(6);
            rc.OffButtonWasPushed(6);

            Console.ReadLine();
        }

        private void Test4()
        {
         

            RemoteControlLambda rc = new RemoteControlLambda(8);
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");



            rc.SetCommand(0, livingRoomLight.On, livingRoomLight.Off);
            rc.SetCommand(1, kitchenLight.On, kitchenLight.Off);
            rc.SetCommand(2, ceilingFan.SetHigh, ceilingFan.TurnOff);
            rc.SetCommand(3, garageDoor.Open, garageDoor.Close);
            rc.SetCommand(4, () => { stereo.On(); stereo.SetCd(); }, stereo.Off);


            Console.Write(rc);

            rc.OnButtonWasPushed(0);
            rc.OffButtonWasPushed(0);
            rc.OnButtonWasPushed(1);
            rc.OffButtonWasPushed(1);
            rc.OnButtonWasPushed(2);
            rc.OffButtonWasPushed(2);
            rc.OnButtonWasPushed(3);
            rc.OffButtonWasPushed(3);
            rc.OnButtonWasPushed(4);
            rc.OffButtonWasPushed(4);
            rc.OnButtonWasPushed(5);
            rc.OffButtonWasPushed(5);
            rc.OnButtonWasPushed(6);
            rc.OffButtonWasPushed(6);

          
        }

        private void Test5()
        {
           

            RemoteControl rc = new RemoteControl(8);
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor1 = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");

            OnCommand<Light> livingRoomLightOn = new OnCommand<Light>(livingRoomLight);
            OffCommand<Light> livingRoomLightOff = new OffCommand<Light>(livingRoomLight);

            OnCommand<Light> kitchenLightOnCommand = new OnCommand<Light>(kitchenLight);
            OffCommand<Light> kitchenLightOffCommand = new OffCommand<Light>(kitchenLight);

            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan); 
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor1);
            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor1);

            StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            OffCommand<Stereo> stereoOffCommand = new OffCommand<Stereo>(stereo);


            rc.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            rc.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
            rc.SetCommand(2, ceilingFanHighCommand, ceilingFanOffCommand);
            rc.SetCommand(3, ceilingFanMediumCommand, ceilingFanOffCommand);
            rc.SetCommand(4, ceilingFanLowCommand, ceilingFanOffCommand);
            rc.SetCommand(5, garageDoorOpenCommand, garageDoorCloseCommand);
            rc.SetCommand(6, stereoOnWithCDCommand, stereoOffCommand);


            Console.Write(rc);

            rc.OnButtonWasPushed(0);
            rc.OffButtonWasPushed(0);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(1);
            rc.OffButtonWasPushed(1);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(2);
            rc.OffButtonWasPushed(2);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(3);
            rc.OffButtonWasPushed(3);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(4);
            rc.OffButtonWasPushed(4);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(5);
            rc.OffButtonWasPushed(5);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(6);
            rc.OffButtonWasPushed(6);
            Console.Write(rc);
            rc.UndoButtonWasPushed();

          
        }

        private void Test6()
        {
            

            RemoteControl rc = new RemoteControl(8);
            Light livingRoomLight = new Light("Living Room");
            TV livingRoomTV = new TV("Living Room");
            HotTub hotTub = new HotTub("Back Deck");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor1 = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");

            OnCommand<Light> livingRoomLightOn = new OnCommand<Light>(livingRoomLight);
            OffCommand<Light> livingRoomLightOff = new OffCommand<Light>(livingRoomLight);

            OnCommand<Light> kitchenLightOnCommand = new OnCommand<Light>(kitchenLight);
            OffCommand<Light> kitchenLightOffCommand = new OffCommand<Light>(kitchenLight);

            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor1);
            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor1);

            StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            OffCommand<Stereo> stereoOffCommand = new OffCommand<Stereo>(stereo);

            #region MacroCommand

            #region On

            OnCommand<TV> tvOnCommand = new OnCommand<TV>(livingRoomTV);
            OnCommand<HotTub> hotTubOnCommand = new OnCommand<HotTub>(hotTub);
            MacroCommand macroOnCommand = new MacroCommand(livingRoomLightOn, stereoOnWithCDCommand, tvOnCommand, hotTubOnCommand);

            #endregion

            #region Off

            OffCommand<TV> tvOffCommand = new OffCommand<TV>(livingRoomTV);
            OffCommand<HotTub> hotTubOffCommand = new OffCommand<HotTub>(hotTub);

            MacroCommand macroOffCommand = new MacroCommand(livingRoomLightOff, stereoOffCommand, tvOffCommand, hotTubOffCommand);

            #endregion

            #endregion


            rc.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            rc.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
            rc.SetCommand(2, ceilingFanHighCommand, ceilingFanOffCommand);
            rc.SetCommand(3, ceilingFanMediumCommand, ceilingFanOffCommand);
            rc.SetCommand(4, ceilingFanLowCommand, ceilingFanOffCommand);
            rc.SetCommand(5, garageDoorOpenCommand, garageDoorCloseCommand);
            rc.SetCommand(6, stereoOnWithCDCommand, stereoOffCommand);
            rc.SetCommand(7, macroOnCommand, macroOffCommand);


            Console.Write(rc);

            rc.OnButtonWasPushed(0);
            rc.OffButtonWasPushed(0);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(1);
            rc.OffButtonWasPushed(1);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(2);
            rc.OffButtonWasPushed(2);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(3);
            rc.OffButtonWasPushed(3);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(4);
            rc.OffButtonWasPushed(4);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(5);
            rc.OffButtonWasPushed(5);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(6);
            rc.OffButtonWasPushed(6);
            Console.Write(rc);
            rc.UndoButtonWasPushed();
            rc.OnButtonWasPushed(7);
            rc.OffButtonWasPushed(7);
            Console.Write(rc);
            rc.UndoButtonWasPushed();

         
        }

        private void Test1()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();

            Light light = new Light("Kitchen");
            OnCommand<Light> lightOn = new OnCommand<Light>(light);
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
        }

        private static void Test2()
        {

            SimpleRemoteControl remote = new SimpleRemoteControl();

            GarageDoor garageDoor = new GarageDoor("Number 1");
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();
        }
    }
}
