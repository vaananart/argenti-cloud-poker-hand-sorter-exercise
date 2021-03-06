
<##
# TODO: This can be done better in the future.
#>

## NOTE: the commented command lines below, Step 2 and 3, are excutable commands to clean and build the solution
## from the root of the repository. You should be able to copy and paste those commands and execute them in the
## commandline prompt.

<## Start-Sleep commands: Sleep commands are used between cleaning and building the solution from
## fresh. Both the clean and build commands where executed independently as thread processes.
## This mess up the copying of the poker-hands.txt
## Hence, sleep is introduced to simulate cascade-effect operations.  
##> 

## STEP 1: clean any existing folder
Remove-Item .\PokerHandSorterConsoleApp\output\ -Recurse
Start-Sleep -Seconds 2

## STEP 2: CMD: dotnet clean .\PokerHandSorterConsoleApp
Start-Process -FilePath 'dotnet' -WorkingDirectory ".\PokerHandSorterConsoleApp" -ArgumentList 'clean'
Start-Sleep -Seconds 2

## Step 3: CMD: dotnet build .\PokerHandSorterConsoleApp
Start-Process -FilePath 'dotnet' -WorkingDirectory ".\PokerHandSorterConsoleApp" -ArgumentList 'build'
Start-Sleep -Seconds 2

## Step 4: we copy over the data to the folder where the executable resides
Copy-Item .\datasrc\poker-hands.txt .\PokerHandSorterConsoleApp\output\net5.0\