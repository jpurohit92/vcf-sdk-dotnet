# Vcenter.Automation.OpenApi.Model.ContentLibraryUsagesAddSpec
The Content.Library.Usages.AddSpec schema defines the information required to add a resource usage on a content library.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceUrn** | **string** | A Uniform Resource Name (URN) of the resource that is using the content library.    The URN is a fully qualified, unique string that identifies a specific instance of a resource such as a virtual machine, supervisor, namespace, cluster, etc. This identifier enables the Content Library service to track which resources are using a given content library.     The expected URN format is: &#x60;&lt;urn-scheme&gt;:&lt;global-namespace&gt;:&lt;resource-type&gt;:&lt;resource-id&gt;&#x60;, where:     - &#x60;urn-scheme&#x60; specifies the identifier scheme (e.g., &#x60;urn&#x60;)    - &#x60;global-namespace&#x60; represents the owning domain (e.g., &#x60;vmomi&#x60;)    - &#x60;resource-type&#x60; indicates the type of the resource (e.g., &#x60;vm&#x60;, &#x60;supervisor&#x60;)    - &#x60;resource-id&#x60; is the unique identifier for the resource (e.g., &#x60;vm-12&#x60;)         Example URNs:     - &#x60;urn:vmomi:vm:vm-12&#x60;    - &#x60;urn:vmomi:supervisor:sup-56789&#x60;    - &#x60;urn:vmomi:namespace:ns-abcde&#x60;       This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

