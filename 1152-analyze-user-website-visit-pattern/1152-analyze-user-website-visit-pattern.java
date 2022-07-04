class Solution {
    public List<String> mostVisitedPattern(String[] username, int[] timestamp, String[] website) {
        if(username == null || timestamp == null || website == null) {
            return new ArrayList<>();
        }
        int n = username.length;
        
        Map<String, List<Visit>> userVisitMap = buildMap(username, timestamp, website);
        Map<String, Integer> sequenceFreq = new HashMap<>();
        
        String res = "";
        for(String name : userVisitMap.keySet()) {        
            
            List<Visit> visits = userVisitMap.get(name);
            Set<String> set = new HashSet<>();// set for repeat visit. home/home/home should count as one
            
            //brute force find all 3 pair sequence O(n^3) * sb.toString O(n)-> total O(n^4)
            for(int i = 0; i < visits.size() - 2; i++) {
                for(int j = i + 1; j < visits.size() - 1; j++) {
                    for(int k = j + 1; k < visits.size(); k++) {
                        StringBuilder sb = new StringBuilder();
                        sb.append((visits.get(i)).web).append(" ").append((visits.get(j)).web).append(" ").append(((visits.get(k)).web));
                        String sequence3 = sb.toString();
                        
                        if (!set.contains(sequence3)) {
                            sequenceFreq.put(sequence3, sequenceFreq.getOrDefault(sequence3, 0) + 1);
                            set.add(sequence3);
                        }
                        if (res.equals("") || sequenceFreq.get(res) < sequenceFreq.get(sequence3) || (sequenceFreq.get(res) == sequenceFreq.get(sequence3) && res.compareTo(sequence3) > 0)) {
                            // res is the highest freq, if freq same choose lexi order smaller
                            res = sequence3;
                        }
                    }
                }
            }
        }
        return Arrays.asList(res.split(" "));
    }
    //build a userVisitMap and visit is sort by time
    private Map<String, List<Visit>> buildMap(String[] username, int[] timestamp, String[] website) {
        Map<String, List<Visit>> map = new HashMap<>();
        for(int i = 0; i < username.length; i++) {
            map.putIfAbsent(username[i], new ArrayList<>());
            map.get(username[i]).add(new Visit(timestamp[i], website[i]));
        }
        
        for(String name: map.keySet()) {
            List<Visit> visits = map.get(name);
            Collections.sort(visits, (v1,v2) -> v1.time - v2.time);
        }
        return map;
    }
    
    class Visit{
        int time;
        String web;
        public Visit(int time, String web) {
            this.time = time;
            this.web = web;
        }
    }
}