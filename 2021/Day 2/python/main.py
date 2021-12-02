# Input fetch
with open('data.input') as file:
    lines = [[int(instruction) if index == 1 else instruction for index, instruction
              in enumerate(line.strip('\n').split(' '))] for line in file.readlines()]

# Day 2 / A

horizontal = 0
depth = 0

for line in lines:
    if line[0] == "forward":
        horizontal += line[1]
    elif line[0] == "down":
        depth += line[1]
    elif line[0] == "up":
        depth -= line[1]

print(horizontal * depth)

# Day 2 / B

horizontal = 0
depth = 0
aim = 0

for line in lines:
    if line[0] == "forward":
        horizontal += line[1]
        depth += aim * line[1]
    elif line[0] == "down":
        aim += line[1]
    elif line[0] == "up":
        aim -= line[1]

print(horizontal * depth)
