
## Build Steps
<!-- For windows and linux -->

## Adding an extension to an Extension bundle
- Add extension to extension.json and related steps
- Includes the steps add templates to extension bundle
- Add your extension to the test project as well

## Testing your changes
- Option one private storage account / cdn
- Option 2 Local file changes

## Creating a custom extension Bundle
- Change the Id
- Change the version
- Upload bundle to storage account

## Bundle design
- What is extension bundle
- Problem solved by extension bundle
- Bundle design
    - Bundle is generated by combination of extensions
    - Host reads bundle configuiration
    - Finds the latest matching extension bundle version.
        - This depends on the current hosting environment
        - If in azure / find one localy
        - If in core tools download to machine (from a default source or from a storage account)