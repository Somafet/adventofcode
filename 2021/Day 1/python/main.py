# Day 1 - A
numberOfIncreases = 0
with open('data.input') as file:
    prevLine = None

    for line in file:
        line = int(line.strip('\n'))
        numberOfIncreases += 1 if prevLine is not None and line > prevLine else 0
        prevLine = line

print(numberOfIncreases)

# Day 1 - B
with open('data.input') as file:
    lines = [int(line.strip('\n')) for line in file]

slidingCounter = 0
prevThreeSum = None

for i in range(2, len(lines)):
    currentThreeSum = lines[i] + lines[i - 1] + lines[i - 2]
    slidingCounter += 1 if prevThreeSum is not None and currentThreeSum > prevThreeSum else 0
    prevThreeSum = currentThreeSum

print(slidingCounter)
