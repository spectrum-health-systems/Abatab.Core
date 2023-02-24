# Code snippits

## The Debuggler

* The Debuggler is a *very* basic debugging utility.
* Debuggler logic is in Abatab.Core.Utilities, so you will need a `using Abatab.Core.Utilities;` statement in your class.
* Debuggler files are written to **"C:\AbatabData\Debuggler\"**, which has to exist prior to using Debuggler.

### Temporary debugging

This one-line statement can be anywhere, and should be removed after debugging is complete:

```
Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

-or-

Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name, "Content goes here");
```

### Permanent

In some cases, you may want to have the ability to create Debuggler logs without having to add or uncomment code. You can do this with the following syntax:


```
if (DebbuglerMode == "enabled")
{
    Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);
}

-or-

if (DebbuglerMode == "enabled")
{
    Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name, "Content goes here");
}
```
