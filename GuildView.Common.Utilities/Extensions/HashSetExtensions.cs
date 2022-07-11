﻿namespace GuildView.Common.Utilities.Extensions;

public static class HashSetExtensions
{
   public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> collection)
   {
      foreach (var item in collection)
      {
         set.Add(item);
      }
   } 
}