﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F9S1.RememberMe
{
    enum Command
    {
        add,
        edit,
        delete,
        clear,
        undo,
        redo,
        error,
        search, 
        find,
        display,
        archive,
        label
    };

    class Parser
    {
        public Parser()
        {

        }
        private Command ToCommand(string input)
        {
            switch (input)
            {
                case "edit":
                    return Command.edit;
                case "edit:":
                    return Command.edit;
                case "delete":
                    return Command.delete;
                case "clear":
                    return Command.clear;
                case "undo":
                    return Command.undo;
                case "redo":
                    return Command.redo;
                case "display":
                    return Command.display;
                case "search":
                    return Command.search;
                case "find":
                    return Command.find;
                case "label":
                    return Command.label;
                case "archive":
                    return Command.archive;
                default:
                    return Command.add;
            }
        }
        public List<string> SymbolParse(string input, List<string> labels)
        {
            List<string> parsedInput = new List<string>(), inputLabels = new List<string>(), betaParse = new List<string>(input.Split(new Char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries)); ;
            string commandName, taskInterval, taskDetails, taskTime, betaInput = new string(input.ToCharArray());
            DateTime deadline;
            bool hasStars = betaInput.Contains("**");
            betaInput = betaInput.Replace("**", "");
            
            commandName = "add";
            if (betaParse[0].Trim().ToLower().Equals("add"))
            {
                string[] temp = betaInput.Split(new Char[] { ' ' , ';'}, 2, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length < 2)
                {
                    parsedInput.Add(Utility.ERROR);
                    parsedInput.Add(Utility.ADD_INPUT_ERROR);
                    return parsedInput;
                }
                else
                    betaInput = temp[1];
            }

            if (input.Contains(';'))
            {
                List<string> toBeChecked =  ColonParse(betaInput, labels);
                if (toBeChecked[1].Length == 0)
                {
                    parsedInput.Add(Utility.ERROR);
                    parsedInput.Add(Utility.ADD_INPUT_ERROR);
                    return parsedInput;
                }
                if (toBeChecked[2] == Utility.DEFAULT_ERROR_DATE.ToString())
                {
                    parsedInput.Add(Utility.ERROR);
                    parsedInput.Add(Utility.DATE_ERROR);
                    return parsedInput;
                }
                if (toBeChecked[3].Length == 0)
                {
                    toBeChecked[3] = Utility.DEFAULT_LABEL;
                }
                else if (!CheckLabels(toBeChecked[3], labels))
                {
                    parsedInput.Add(Utility.ERROR);
                    parsedInput.Add(Utility.LABEL_UNDEFINED_ERROR);
                    return parsedInput;
                }
                return toBeChecked;
            }
            
            if (!(betaInput.Contains('#')))
                inputLabels.Add(Utility.DEFAULT_LABEL);
            else
            {
                for (int i = 0; i < betaParse.Count; )
                {
                    if (betaParse[i].Contains('#'))         //last words
                    {
                            inputLabels.Add(betaParse[i].Substring(1));
                            betaParse.RemoveAt(i);
                    }
                    else
                        i++;
                }
            }

            if (!CheckLabels(inputLabels, labels))
            {
                parsedInput.Add(Utility.ERROR);
                parsedInput.Add(Utility.LABEL_UNDEFINED_ERROR);
                return parsedInput;
            }

            if (!(betaInput.Contains('@')))
            {
                char[] splitter = new char[] { ' ' };
                taskTime = Utility.DEFAULT_NO_TIME;
                taskInterval = Utility.NO_INTERVAL.ToString();
                taskDetails = betaInput.Split('@', '#')[0].Trim();
            }
            else
            {
                taskDetails = betaInput.Split('@', '#')[0].Trim();
                int _at = betaInput.IndexOf('@');
                int _hash = betaInput.IndexOf('#');
                int length = betaInput.Length;
                taskTime = betaInput.Substring(_at + 1, ((_hash - _at > 0) ? _hash - _at - 1: length - _at - 1));
                taskInterval = GetRepeat(taskTime).ToString();
                if (taskTime.Contains('%'))
                    taskTime.Replace(taskTime.Substring(taskTime.IndexOf('%')).Split(' ', ';')[0], "");
                deadline = ToDate(taskTime);
                if (deadline.Equals(Utility.DEFAULT_ERROR_DATE))
                {
                    parsedInput.Add(Utility.ERROR);
                    parsedInput.Add(Utility.DATE_ERROR);
                    return parsedInput;
                }
                else
                    taskTime = deadline.ToString();
            }

            if (taskDetails == null || taskDetails == "")
            {
                parsedInput.Add(Utility.ERROR);
                parsedInput.Add(Utility.ADD_INPUT_ERROR);
                return parsedInput;
            }

            parsedInput.Add(commandName);
            parsedInput.Add(taskDetails);
            parsedInput.Add(taskTime);
            parsedInput.Add(String.Concat(inputLabels));
            parsedInput.Add(hasStars.ToString());
            parsedInput.Add(taskInterval);
            return parsedInput;
        }

        private bool CheckLabels(string input, List<string> labels)
        {
            string[] inputSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in inputSplit)
            {
                if (!labels.Contains(item))
                    return false;
            }
            return true;
        }
        private bool CheckLabels(List<string> input, List<string> labels)
        {
            foreach (string item in input)
            {
                if (!labels.Contains(item))
                    return false;
            }
            return true;
        }

        public List<string> LabelParse(string input, List<string> labels)
        {
            char[] splitter = new char[] { ' ' , ';'};
            List<string> parsedInput = new List<string>(), betaParse = new List<string>(input.Split(splitter, StringSplitOptions.RemoveEmptyEntries));
            if (betaParse.Count < 3 || (betaParse[1] != "add" && betaParse[1] != "delete"))
            {
                parsedInput.Add(Utility.ERROR);
                parsedInput.Add(Utility.LABEL_INPUT_ERROR);
                return parsedInput;
            }
            parsedInput.Add(betaParse[0].ToLower());
            parsedInput.Add(betaParse[1].ToLower());
            parsedInput.Add(betaParse[2].ToLower());
            return parsedInput;
        }

        public List<string> CommandParse(string input)
        {
            char[] splitter = new char[] { ' ' , ';'};
            List<string> parsedInput = new List<string>(input.Split(splitter, 2, StringSplitOptions.RemoveEmptyEntries));
            parsedInput[0] = parsedInput[0].ToLower();
            return parsedInput;
        }

        private TimeSpan GetRepeat(string dateInput)
        {
            TimeSpan interval;
            if (dateInput.Contains('%'))
            {
                int posmod = dateInput.IndexOf('%');
                string next = dateInput.Substring(posmod + 1).Split(' ', ';')[0];
                if (next == "w" || next == "weekly")
                {
                    interval = Utility.WEEK_INTERVAL;
                }
                else if (next == "m" || next == "monthly")
                {
                    interval = Utility.MONTH_INTERVAL;
                }
                else if (Char.IsDigit(next[0]))
                {
                    interval = new TimeSpan(int.Parse(next), 0, 0, 0);
                }
                else
                    interval = Utility.NO_INTERVAL;
            }
            else
                interval = Utility.NO_INTERVAL;
            return interval;
        }

        public List<string> ColonParse(string input, List<string> labels)
        {
            List<string> betaInput = new List<string>(input.Split(';')), parsedInput = new List<string>();
            parsedInput.Add("add");
            parsedInput.Add(betaInput[0].Trim());                                       //Task Details 
            parsedInput.Add(ToDate(betaInput[1].Trim().ToLower()).ToString());          //Deadline
            parsedInput.Add(betaInput[2].Trim().ToLower());                             //Labels
            parsedInput.Add((betaInput[3].Trim().ToLower() == "high").ToString());      //Priority
            parsedInput.Add(GetRepeat(betaInput[1].Trim()).ToString());                 //Repetition
            return parsedInput;
        }

        public List<string> InputParse(string input, List<string> labels)
        {
            
            Command inputCommand = ToCommand(input.Trim().Split(new char[] { ' ', ';' })[0].ToLower());
            List<string> parsedInput = new List<string>();
            if (inputCommand == Command.add)
            {
                parsedInput = SymbolParse(input, labels);
            }
            else if (inputCommand == Command.label)
            {
                parsedInput = LabelParse(input, labels);
            }
            else
            {
                parsedInput = CommandParse(input);
            }
            return parsedInput;
        }

        public bool isDayValid(string day)
        {
            if (day == "monday" || day == "mon"
                || day == "tuesday" || day == "tue"
                || day == "wednesday" || day == "wed"
                || day == "thursday" || day == "thu"
                || day == "friday" || day == "fri"
                || day == "saturday" || day == "sat"
                || day == "sunday" || day == "sun"
                || day == "today"
                || day == "tomorrow")
                return true;
            else
            {
                return false;
            }
        }
        private DayOfWeek toDay(string day)
        {
            day = day.Trim();
            if (day == "monday" || day == "mon")
                return DayOfWeek.Monday;
            else if (day == "tuesday" || day == "tue")
                return DayOfWeek.Tuesday;
            else if (day == "wednesday" || day == "wed")
                return DayOfWeek.Wednesday;
            else if (day == "thursday" || day == "thu")
                return DayOfWeek.Thursday;
            else if (day == "friday" || day == "fri")
                return DayOfWeek.Friday;
            else if (day == "saturday" || day == "sat")
                return DayOfWeek.Saturday;
            else if (day == "sunday" || day == "sun")
                return DayOfWeek.Sunday;
            else if (day == "tomorrow")
                return System.DateTime.Today.AddDays(1).DayOfWeek;
            else
                return System.DateTime.Today.DayOfWeek;
        }
        private int NumberOfDays(string day)
        {
            DayOfWeek deadline = toDay(day);
            DayOfWeek curDay = System.DateTime.Today.DayOfWeek;
            if (deadline >= curDay)
                return (deadline - curDay);
            else
                return deadline - curDay + 7;
        }
        public DateTime ToDate(string toBeConverted)
        {
            if (toBeConverted.Length == 0)
                return Utility.DEFAULT_UNDEFINED_DATE;
            DateTime tempDate = new DateTime();
            if (isDayValid(toBeConverted.ToLower().Trim()))
            {
                tempDate = System.DateTime.Today.Date;
                int x = NumberOfDays(toBeConverted);
                tempDate = tempDate.AddDays(x * 1.0);
            }
            else
            {
                try
                {
                    tempDate = DateTime.Parse(toBeConverted);
                }
                catch (Exception e)
                {
                    if (e is FormatException)
                        return Utility.DEFAULT_ERROR_DATE;
                }
            }
            return tempDate;
        }
    }
}
