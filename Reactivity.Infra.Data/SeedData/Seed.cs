using Reactivity.Domain.Models;
using Reactivity.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reactivity.Infra.Data.SeedData
{
    public class Seed
    {

        public static void SeedData(ReactivlyDBContext context)
        {
            if (!context.Activities.Any())
            {
                var activities = new List<Activity> {
                new Activity
                 {
                    Title="Future Activity 1",
                    Date=DateTime.Now.AddMonths(1),
                    Description="Activity 1 month in future",
                    Category="Culture",
                    City="London",
                    Venue="Nautural History Museum"
                 },
                new Activity
                 {
                    Title="Future Activity 2",
                    Date=DateTime.Now.AddMonths(2),
                    Description="Activity 2 month in future",
                    Category="Culture 2",
                    City="London 2",
                    Venue="Nautural History Museum 2"
                 },
                new Activity
                 {
                    Title="Future Activity 3",
                    Date=DateTime.Now.AddMonths(3),
                    Description="Activity 3 month in future",
                    Category="Culture 3",
                    City="London 3",
                    Venue="Nautural History Museum 3"
                 },
                new Activity
                 {
                    Title="Future Activity 4",
                    Date=DateTime.Now.AddMonths(4),
                    Description="Activity 4 month in future",
                    Category="Culture 4",
                    City="London 4",
                    Venue="Nautural History Museum 4"
                 },
                new Activity
                 {
                    Title="Future Activity 5",
                    Date=DateTime.Now.AddMonths(5),
                    Description="Activity 5 month in future",
                    Category="Culture 5",
                    City="London 5",
                    Venue="Nautural History Museum 5"
                 },
                new Activity
                 {
                    Title="Future Activity 6",
                    Date=DateTime.Now.AddMonths(6),
                    Description="Activity 6 month in future",
                    Category="Culture 6",
                    City="London 6",
                    Venue="Nautural History Museum 6"
                 },
                new Activity
                 {
                    Title="Future Activity 7",
                    Date=DateTime.Now.AddMonths(7),
                    Description="Activity 7 month in future",
                    Category="Culture 7",
                    City="London 7",
                    Venue="Nautural History Museum 7"
                 },
                new Activity
                 {
                    Title="Future Activity 8",
                    Date=DateTime.Now.AddMonths(8),
                    Description="Activity 8 month in future",
                    Category="Culture 8",
                    City="London 8",
                    Venue="Nautural History Museum 8"
                 },
                new Activity
                 {
                    Title="Future Activity 9",
                    Date=DateTime.Now.AddMonths(9),
                    Description="Activity 9 month in future",
                    Category="Culture 9",
                    City="London 9",
                    Venue="Nautural History Museum 9"
                 },
                new Activity
                 {
                    Title="Future Activity 10",
                    Date=DateTime.Now.AddMonths(1),
                    Description="Activity 10 month in future",
                    Category="Culture 10",
                    City="London 10",
                    Venue="Nautural History Museum 10"
                 },
                new Activity
                 {
                    Title="Future Activity 11",
                    Date=DateTime.Now.AddMonths(11),
                    Description="Activity 11 month in future",
                    Category="Culture 11",
                    City="London 11",
                    Venue="Nautural History Museum 11"
                 },
                new Activity
                 {
                    Title="Future Activity 12",
                    Date=DateTime.Now.AddMonths(12),
                    Description="Activity 12 month in future",
                    Category="Culture 12",
                    City="London 12",
                    Venue="Nautural History Museum 12"
                 }
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }

        }
    }
}
