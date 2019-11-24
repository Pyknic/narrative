# Narrative Engine
Engine for writing narrative and dialogue-based games in C#. Game nodes such as actors and places are loaded from XML-files when the game starts. Dialogue is generated using embedded C#-scripts. Everything between a pair of ` `` ` will be interpreted as C#-code.

**Example:**
```markdown
As you walk down `Place.TheName`, you see `Other.Name` sitting in a corner 
with `Other.HisHer` face in `Other.HisHer` hands, the tears are streaming. 
Today `Other.HeShe` is wearing a `RandInt % 2 == 0 ? "blue" : "red"` shirt.
```

The text above could be invoked using the following context for `Other`:

```xml
<?xml version="1.0"?>
<Actor xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <Id>248617626</Id>
  <Name>Sarah</Name>
  <Gender>FEMALE</Gender>
</Actor>
```

The generated text would then be:
> As you walk down the corridor, you see Sarah sitting in a corner with her face in her hands, the tears are streaming. Today she is wearing a red shirt.

# License
Copyright 2019 Emil Forslund

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
