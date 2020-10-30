using System;
using System.Collections.Generic;

class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxLen = 0;
        var lastSeenAt = new Dictionary<char, int>();
        int cutoff = -1;

        for(var i1 = 0; i1!=s.Length; i1++){
            char c = s[i1];
            int lastSeen = -1;
            if (lastSeenAt.ContainsKey(c)) {
                lastSeen = lastSeenAt[c];
            }
            var Len = i1 - Math.Max(lastSeen,cutoff);

            if(maxLen < Len){
                maxLen = Len;
            }

            if (!lastSeenAt.ContainsKey(c)) {
                lastSeenAt.Add(c,i1);
            }
            else{
                if(cutoff < lastSeenAt[c]){
                    cutoff = lastSeenAt[c];
                }
                lastSeenAt[c] = i1;
            }
        }
        return maxLen;
    }
}