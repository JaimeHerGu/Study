## Day 1 — async/await

### What I built
Async file processor that reads multiple files concurrently
using Task.WhenAll and handles missing files gracefully.

### Key learnings
- async/await is about freeing threads during I/O, not multi-threading
- Task.WhenAll runs tasks in parallel — faster than sequential awaits
- async goes all the way down — never block with .Result or .Wait()

### What confused me
The syntax similar to LINQ
