﻿namespace RecursiveDescent.Parsers.HStore {
    internal record RuleListNode : Node {
        public required RuleNode? Rule { get; init; }
        public required RuleListNode? More { get; init; }
    }
}