#!/usr/bin/env bash

# extract_classes.sh - Find and list all class names in a .NET/C# project
# Usage: ./extract_classes.sh [path/to/project]   (defaults to current directory)

SEARCH_DIR="${1:-.}"

echo "Scanning for C# classes in: $SEARCH_DIR"
echo "----------------------------------------"

# Find all .cs files and search for class declarations
find "$SEARCH_DIR" -type f -name '*.cs' -print0 | while IFS= read -r -d '' file; do
	# Use grep with Perl-compatible regex to extract class names.
	# Pattern explanation:
	#   ^\s*                      - optional leading whitespace
	#   (?:[a-zA-Z_]\w*\s+)*     - optional modifiers (public, static, sealed, etc.)
	#   class\s+                  - keyword "class" followed by whitespace
	#   (\w+(?:<[^>]+>)?)        - capture: class name (word chars) optionally followed by <...> for generics
	#                               (simple generics, not nested angle brackets)
	grep -Po '^\s*(?:[a-zA-Z_]\w*\s+)*class\s+\K\w+(?:<[^>]+>)?' "$file" 2>/dev/null | while read -r classname; do
		echo "$file  ->  $classname"
	done
done
