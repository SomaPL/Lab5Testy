using Lab5Testy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Lab5Testy.Task;

namespace TestProject1
{
    internal class TaskManagerTest
    {
        private TaskManager _taskManager;

        [SetUp]
        public void Setup()
        {
            _taskManager=new TaskManager(); ;
        }

        [Test]
        public void AddTask_ShouldIncreaseTaskCount()
        {
            //Arrange
            var task = new Task("Task task");
            //Act
            _taskManager.AddTask(task);
            //Assert
            Assert.AreEqual(1, _taskManager.GetTasks().Count);
        }

        [Test]
        public void RemoveTask_ExistingTask_ShouldDecreaseTaskCount()
        {
            //Arrange
            var task1 = new Task("Task Task1");
            var task2 = new Task("Task Task2");
            _taskManager.AddTask(task1);
            _taskManager.AddTask(task2);
            //Act
            _taskManager.RemoveTask(1);
            //Assert
            Assert.AreEqual(1, _taskManager.GetTasks().Count);
        }
        [Test]
        public void RemoveTask_NonExistingTask_ShouldNotChangeTaskCount()
        {
            //Arrange
            var task3 = new Task("Task Task3");
            _taskManager.AddTask(task3);
            //Act
            _taskManager.RemoveTask(2);
            //Assert
            Assert.AreEqual(1, _taskManager.GetTasks().Count);
        }
    }
}
