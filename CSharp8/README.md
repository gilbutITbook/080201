At the time of this writing, the C# 8 preview builds are separated
into three feature sets:

- Nullable reference types
- Enhanced patterns, switch expressions, ranges
- Async support for foreach/using

I've created a separate solution for each of these, away from the
main book's code. When a unified preview comes out, I'll update this
to a single solution.

Additionally, right now (January 23rd 2019) the VS2019 preview only
supports nullable reference types as far as I'm aware. I've updated
that solution/project suitably (and used a .NET Core project). As
VS2019 previews become more capable, I'll update everything else.

I won't update this code with *all* C# 8 features - only those
described in C# in Depth. For a more comprehensive set of demos -
but ones which are geared towards live presentation as part of a
conference talk - see https://github.com/jskeet/democode
