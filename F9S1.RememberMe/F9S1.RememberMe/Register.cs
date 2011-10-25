﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F9S1.RememberMe
{
    class Register
    {
        List<Task> taskList;
        public List<Task> TaskList
        {
            get
            {
                return taskList;
            }
        }
        Stack<List<Task>> undoStack, redoStack;
        
        public Register(List<string> stringListTasks)
        {
            taskList = new List<Task>();
            for (int i = 0; i < stringListTasks.Count; i++)
            {
                taskList.Add(new Task(stringListTasks[i]));
            }
            undoStack = new Stack<List<Task>>();
            redoStack = new Stack<List<Task>>();
            undoStack.Push(TaskList);
        }
        //public void SetTasks(List<string> stringList)
        //{
        //}
        public List<string> GetList()
        {
            List<string> stringListTasks = new List<string>();
            for (int i = 0; i < taskList.Count; i++)
            {
                stringListTasks.Add(taskList[i].ToString());
            }
            return stringListTasks;
        }
        public void UpdateTasks()
        {
            if ((redoStack.Count > 0) && (taskList.Equals(redoStack.Peek())))
            {
                undoStack.Push(redoStack.Pop());
            }
            else
            {
                undoStack.Push(taskList);
                redoStack.Clear();
            }
        }
        public bool AddTask(List<string> newTask)
        {
            newTask[0] = CheckIfDuplicate(newTask[0]);
            taskList.Add(new Task(newTask));
            return true;
        }

        string CheckIfDuplicate(string taskDetails)
        {
            int count = 0;
            string newDetails = taskDetails;
            bool isModified = true;
            while (isModified)
            {
                isModified = false;
                for (int i = 0; i < taskList.Count; i++)
                    if (taskList[i].Details == newDetails)
                    {
                        count++;
                        isModified = true;
                    }
                if (count != 0)
                {
                    newDetails = taskDetails + "(" + count + ")";
                }
            }
            return newDetails;
        }

        public bool DeleteTask(string taskDetails)
        {
            Task foundTask = SearchTask(taskDetails);
            if (foundTask != null)
            {
                taskList.Remove(foundTask);
                return true;
            }
            return false;
        }
        public bool ArchiveTask(string taskDetails)
        {
            Task foundTask = SearchTask(taskDetails);
            if (foundTask != null && !foundTask.IsArchived) //archive how?
            {
                foundTask.IsArchived = true;
                return true;
            }
            return false;
        }
        public bool ClearTasks()
        {
            taskList.Clear();
            return true;
        }
        public string MoveTaskToEnd(string taskDetails)
        {
            Task foundTask = SearchTask(taskDetails);
            if (foundTask != null)
            {
                taskList.Remove(foundTask);
                taskList.Add(foundTask);
                return foundTask.Details;
            }
            return "";
        }

        public bool EditTask(List<string> editInput)
        {
            if (editInput.Count < 5)
                return false;
            if (editInput[0] != null && editInput[0] != "")
            {
                editInput[0] = CheckIfDuplicate(editInput[0]);
                taskList[taskList.Count - 1].Details = editInput[0];
            }
            if (editInput[1] != null && editInput[1] != "")
            {
                taskList[taskList.Count - 1].Deadline = editInput[1];
            }
            if (editInput[2] != null && editInput[2] != "")
            {
                taskList[taskList.Count - 1].Labels = editInput[2];
            }
            if (editInput[3] != null && editInput[3] != "")
            {
                if (editInput[3] == Utility.STARRED)
                {
                    taskList[taskList.Count - 1].IsStarred = true;
                }
                else if (editInput[3] == Utility.UNSTARRED)
                {
                    taskList[taskList.Count - 1].IsStarred = false;
                }
            }
            return true;
        }

        public Task SearchTask(string taskDetails)
        {
            Task toBeFound = null;
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].Details.Equals(taskDetails))
                {
                    toBeFound = taskList[i];
                }
            }
            return toBeFound;
        }

        int CompareByDeadline(Task first, Task second)
        {
            return first.Deadline.CompareTo(second.Deadline);
        }
        public bool SortDeadline()
        {
            taskList.Sort(CompareByPriority);
            taskList.Sort(CompareByDeadline);
            return true;
        }

        int CompareByPriority(Task first, Task second)
        {
            return first.IsStarred.CompareTo(second.IsStarred);
        }
        public bool SortPriority()
        {
            taskList.Sort(CompareByDeadline);
            taskList.Sort(CompareByPriority);
            return true;
        }
        public List<string> Display()
        {
            List<string> taskDetails = new List<string>();
            for (int i = 0; i < taskList.Count; i++)
                taskDetails.Add(taskList[i].GetDisplay());
            if (taskList.Count == 0)
                taskDetails.Add("No tasks :)");
            return taskDetails;
        }

        public bool UndoAction()
        {
            if (undoStack.Count > 1)
            {
                redoStack.Push(undoStack.Pop());
                taskList = new List<Task>(undoStack.Peek());
                return true;
            }
            return false;
        }
        public bool RedoAction()
        {
            if (redoStack.Count > 0)
            {
                taskList = redoStack.Pop();
                undoStack.Push(new List<Task>(taskList));
                return true;
            }
            return false;
        }

        //public bool viewByLabel(ref List<Task> taskList, string parameter, List<Task> currentList)
        //{
        //    int numWithLabel = 0;
        //    for (int i = 0; i < currentList.Count; i++)
        //    {
        //        if (currentList[i].getLabel().ToLower() == parameter.ToLower())
        //        {
        //            taskList.Add(currentList[i]);
        //            numWithLabel++;
        //        }
        //    }
        //    if (numWithLabel == 0)
        //        return false;
        //    else
        //        return true;
        //}

    }
}
