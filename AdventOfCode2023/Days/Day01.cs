using AoCHelper;
using FileParser;

namespace AdventOfCode2023.Days;

public class Day01 : BaseDay
{
    private readonly ParsedFile _input;

    public Day01()
    {
        _input = new ParsedFile(InputFilePath);
    }

    public override ValueTask<string> Solve_1() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 1");

    public override ValueTask<string> Solve_2() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 2");
}