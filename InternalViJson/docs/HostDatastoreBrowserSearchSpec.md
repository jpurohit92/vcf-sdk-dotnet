# Vcenter.ViJson.OpenApi.Model.HostDatastoreBrowserSearchSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | [**List&lt;FileQuery&gt;**](FileQuery.md) | The set of file types to match, search criteria specific to the file type, and the amount of detail for a file.  These search parameters are specific to a file type, meaning that they can be specified only if the file type to which they are associated is in the set. A file type cannot appear more than once in the set.  If this query object is not present, then all files providing only file level details are matched.  | [optional] 
**Details** | [**FileQueryFlags**](FileQueryFlags.md) | This object comprises a set of booleans that describe what details to return for each file.  The file level details apply globally to all matched files.  | [optional] 
**SearchCaseInsensitive** | **bool** | This flag indicates whether or not to search using a case insensitive match on type.  In general the algorithm used to match file types relies on file extensions. Although the specific file extensions used are encapsulated by this API, clients are still allowed to modify the filtering behavior.  By default, the DatastoreBrowser uses a platform-consistent algorithm to determine if a file is of a type. Specifically on Linux, where case is important, the search is case sensitive. On Windows, case is not important, so the search is case insensitive.  In an environment with heterogenous platforms, being platform-consistent may not be desirable. As a result, the default behavior can be overridden by setting this optional flag.  | [optional] 
**MatchPattern** | **List&lt;string&gt;** | Specifies a list of file patterns that must match for a file to be returned.  This search property is a filter that applies globally so that only files matching the specified patterns are returned, regardless of the other search parameters.  | [optional] 
**SortFoldersFirst** | **bool** | By default, files are sorted in alphabetical order regardless of file type.  If this flag is set to \&quot;true\&quot;, folders are placed at the start of the list of results in alphabetical order. The remaining files follow in alphabetical order.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

