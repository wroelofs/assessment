Points of improvement for this software:
1. Add a coded UI test with Visual Studio 2015 Enterprise.
2. Improve input validation / error message(s).
3. Move sequence calculation logic to Web API controller(s) and call them from JavaScript instead of having to use a postback for a more smooth experience.
4. Separate sequence calculations and call each asynchronous for even smoother experience.
5. Add checks to constructors of the sequence classes to prevent bad input.
6. Add unit tests for non happy flows.