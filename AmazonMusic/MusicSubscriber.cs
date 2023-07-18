﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMusic
{
    public class MusicSubscriber
    {
        public string? Message { get; private set; }
        public void Subscribe(MusicPublisher publisher) =>
            publisher.ReleaseEvent += OnRelease;

        public void OnRelease(string releaseType, string name, List<string> release)
        {
            if (releaseType == "Single")
            {
                Message = $"Received notification of new {releaseType} '{name}' released on 'AmazonMusic'.";
            }
            else
            {
                string releaseContent = string.Join(" | ", release);
                Message = $"Received notification of new {releaseType} '{name}' released on 'AmazonMusic' with songs: {releaseContent}.";
            }
        }  
    }
}