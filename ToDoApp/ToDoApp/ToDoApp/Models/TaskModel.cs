﻿using Plugin.CloudFirestore.Attributes;
using ToDoApp.Models.Interfaces;

namespace ToDoApp.Models
{
    public class TaskModel: DraggableItemModel
    {
        [Id]
        public string id { get; set; }
        public bool archived { get; set; }
        public string list { get; set; }
        public string task { get; set; }
        public string userId { get; set; }

        public void Update(TaskModel t)
        {
            archived = t.archived;
            task = t.task;
        }
    }
}
