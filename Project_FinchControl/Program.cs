using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Moreno, Teresia
    // Dated Created: 2/8/2021
    // Last Modified: 3/7/2021
    //
    // **************************************************

    class Program
    {
        private static int danceLevel;
        private static int danceSoundLevel;
        private static int lightSoundLevel;
        private static int numberOfDataPoints;

        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        LightAlarmDisplayMenuScreen(finchRobot);
                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        


        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Dance");
                Console.WriteLine("\tc) Mixing It Up");
                Console.WriteLine("\td) Return to Main Menu");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDance(finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayMixingItUp(finchRobot);
                        break;

                    case "d":
                        TalentShowDisplayReturntoMainMenu(finchRobot);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }


        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Dance                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayDance(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Dance");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int DanceLevel = 0; DanceLevel < 150; danceSoundLevel++)
            {
                finchRobot.setLED(danceLevel, danceLevel, danceLevel);
                finchRobot.noteOn(danceLevel * 120);
            }

            DisplayMenuPrompt("Talent Show Menu");

        }
        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Mixing It Up                  *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayMixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("MixingItUp");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int mixingitupLevel = 0; mixingitupLevel < 25; mixingitupLevel++)
            {
                finchRobot.noteOn(mixingitupLevel * 75);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }
        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Return to Main Menu               *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayReturntoMainMenu(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("ReturntoMainMenu");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int returntoMainMenuLevel = 0; returntoMainMenuLevel < 255; returntoMainMenuLevel++)
            {
                finchRobot.setLED(returntoMainMenuLevel, returntoMainMenuLevel, returntoMainMenuLevel);
                finchRobot.noteOn(returntoMainMenuLevel * 25);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }
        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 255; lightSoundLevel++)
            {
                finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }

        #endregion

       #region DATA RECORDER
        /// <summary>
        /// ************************************
        /// *          Data Recorder Menu      *
        /// ************************************
        /// </summary>
        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            int numberofDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;


            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberofDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetData(numberofDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayGetData(temperatures);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);


        }

        static void DataRecorderDisplayGetData(double[] temperatures)
        {
            DisplayScreenHeader("Show Data");

            //
            // display table headers
            //
            Console.WriteLine(
                    "Recording #".PadLeft(16) +
                    "Temp".PadLeft(16)
                    );
            Console.WriteLine(
                    "---------- ".PadLeft(16) +
                    "-----------".PadLeft(16)
                    );
            //
            // display table data
            //
            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                    (index + 1).ToString().PadLeft(16) +
                    temperatures[index].ToString().PadLeft(16)
                    );
            }

            DisplayContinuePrompt();
        }

        static double[] DataRecorderDisplayGetData(int numberofDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOfDataPoints];

            DisplayScreenHeader("Get Data");

            Console.WriteLine($"\tNumber of data points: {numberOfDataPoints}");
            Console.WriteLine($"\tData point frequency: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine("\tThe Finch robot is ready to begin recording the temperatures data");
            DisplayContinuePrompt();

            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}:{temperatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitInSeconds);
            }
            
            DisplayContinuePrompt();

            return temperatures;
        }

        /// <summary>
        /// get the frequency of data points from the user
        /// </summary>
        /// <returns>frequency of data points</returns>
        static double DataRecorderDisplayGetDataPointFrequency()
        {
            double dataPointFrequency;
            
            DisplayScreenHeader("Data Point Frequency");

            Console.Write("\tfrequency of data points: ");
            

            // validata user input
            double.TryParse(Console.ReadLine(), out dataPointFrequency);

            DisplayContinuePrompt();

            return dataPointFrequency;


        }

        /// <summary>
        /// get the number of data points from the user
        /// </summary>
        /// <returns>number of data points</returns>
        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            int numberOfDataPoints;
            string userResponse;

            DisplayScreenHeader("Number of Data Points");

            Console.Write("Number of data points:");
            userResponse = Console.ReadLine();

            // validata user input
            int.TryParse(userResponse, out numberOfDataPoints);
            
            DisplayContinuePrompt();
           
            return numberOfDataPoints;
        }
        #endregion

        #region ALARM SYSTEM 
        static void LightAlarmDisplayMenuScreen(Finch finchRobot)
        {
            /// <summary>
            /// ************************************
            /// *          Light Alarm Menu      *
            /// ************************************
            /// </summary>
            
            {
               
                Console.CursorVisible = true;

                bool quitMenu = false;
                string menuChoice;

                string sensorsToMonitor ="";
                string rangeType = "";
                int minMaxThresholdValue = 0;
                int timeToMonitor = 0;

                do
                {
                    DisplayScreenHeader("Light Alarm Menu");

                    //
                    // get user menu choice
                    //
                    Console.WriteLine("\ta) Set Sensors to Monitor");
                    Console.WriteLine("\tb) Set Range Type");
                    Console.WriteLine("\tc) Set Minimum/Maximum Threshold Value");
                    Console.WriteLine("\td) Set Time to Monitor");
                    Console.WriteLine("\te) Set Alarm");
                    Console.WriteLine("\tq) Main Menu");
                    Console.Write("\t\tEnter Choice:");
                    menuChoice = Console.ReadLine().ToLower();

                    //
                    // process user menu choice
                    //
                    switch (menuChoice)
                    {
                        case "a":
                             sensorsToMonitor = LightAlarmDisplaySetSensorsToMonitor();
                            break;

                        case "b":
                            rangeType = LightAlarmDisplaySetRangeType();
                            break;

                        case "c":
                            minMaxThresholdValue = LightAlarmSetMinMaxThresholdValue(rangeType, finchRobot);
                            break;

                        case "d":
                            timeToMonitor = LightAlarmSetTimeToMonitor();
                            break;

                        case "e":
                            LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                            break;

                        case "q":
                            quitMenu = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("\tPlease enter a letter for the menu choice.");
                            DisplayContinuePrompt();
                            break;
                    }

                } while (!quitMenu);


            }
        }

        static void LightAlarmSetAlarm(
            Finch finchRobot, 
            string sensorsToMonitor, 
            string rangeType, 
            int minMaxThresholdValue, 
            int timeToMonitor)
        {
            int secondsElasped = 0;
            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;

            DisplayScreenHeader("Set Alarm");

            Console.WriteLine($"Sensors to monitor {sensorsToMonitor}");
            Console.WriteLine("Range Type: {0}", rangeType);
            Console.WriteLine("Min/Max threshold value: " + minMaxThresholdValue);
            Console.WriteLine($"Time to monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any key to being monitoring");
            Console.ReadKey();
            Console.WriteLine();

            while ((secondsElasped < timeToMonitor) && !thresholdExceeded)
            
            if (thresholdExceeded)
            {
                    Console.WriteLine($"The {rangeType} threshold values of exceeded by the current light sensor value of {currentLightSensorValue }.");
            }
            else
            {
                    Console.WriteLine($"The {rangeType} threshold values of {minMaxThresholdValue} was not exceeded.");
                }
            {
                switch (sensorsToMonitor)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        break;
                    
                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;
                    
                    case "both":
                        currentLightSensorValue = (finchRobot.getRightLightSensor() + finchRobot.getLeftLightSensor()) / 2;
                        break;
                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;
                }
                finchRobot.wait(1000);
                secondsElasped++; 
            } 

            DisplayMenuPrompt("Light Alarm");
           
        }

        static int LightAlarmSetTimeToMonitor()
        {
            int timeToMonitor;

            DisplayScreenHeader("Time To Monitor");

            //validate value
            Console.Write($"\tTime To Monitor:");
            int.TryParse(Console.ReadLine(), out timeToMonitor);

            //echo value

            DisplayMenuPrompt("Light Alarm");

            return timeToMonitor;

        }
        static int LightAlarmSetMinMaxThresholdValue(string rangeType, Finch finchRobot)
        {
            int minMaxThresholdValue;

            DisplayScreenHeader("Minimum/Maximum Threshold Value");

            Console.WriteLine($"Left light senor ambient value; {finchRobot.getLeftLightSensor()}");
            Console.WriteLine($"Right light senor ambient value; {finchRobot.getRightLightSensor()}");
            Console.WriteLine();

            //validate value
            Console.Write($"Enter the {rangeType} light sensor value:");
            int.TryParse(Console.ReadLine(), out minMaxThresholdValue);

            //echo value

            DisplayMenuPrompt("Light Alarm");

            return minMaxThresholdValue;

        }

        static string LightAlarmDisplaySetSensorsToMonitor()
        {
            string sensorsToMonitor;

            DisplayScreenHeader("Sensors to Monitor");

            //validate value
            Console.Write("Sensors to monitor [right, left, both]:");
            sensorsToMonitor = Console.ReadLine();

            //echo value

            DisplayMenuPrompt("Light Alarm");

            return sensorsToMonitor;
        }
        static string LightAlarmDisplaySetRangeType()
        {
            string rangeType;

            DisplayScreenHeader("Range Type");

            //validate value
            Console.Write("\tRange Type [minimum, maximum]:");
            rangeType = Console.ReadLine();

            //echo value

            DisplayMenuPrompt("Light Alarm");

            return rangeType;
        }




        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}