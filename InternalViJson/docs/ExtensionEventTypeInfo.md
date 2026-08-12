# Vcenter.ViJson.OpenApi.Model.ExtensionEventTypeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventID** | **string** | The ID of the event type.  Should follow java package naming conventions for uniqueness.  | 
**EventTypeSchema** | **string** | Optional XML descriptor for the EventType.  The structure of this descriptor is:       &lt;EventType&gt;        &lt;eventTypeID&gt;eventID&lt;/eventTypeID&gt;        &lt;description&gt;Optional description for event eventID&lt;/description&gt;        &lt;- - Optional arguments: - -&gt;        &lt;arguments&gt;           &lt;- - Zero or more of: - -&gt;           &lt;argument&gt;             &lt;name&gt;argName&lt;/name&gt;             &lt;type&gt;argtype&lt;/name&gt;           &lt;/argument&gt;        &lt;/arguments&gt;      &lt;/EventType&gt; where _argtype_ can be one of the following: - This is an example list and should be considered as incomplete. &lt;!- - - -&gt; - Primitive types:   - _string_   - _bool_   - _int_   - _long_   - _float_   - _moid_ - Entity reference types:   - _vm_   - _host_   - _resourcepool_   - _computeresource_   - _datacenter_   - _datastore_   - _network_   - _dvs_  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

