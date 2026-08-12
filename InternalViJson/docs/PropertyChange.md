# Vcenter.ViJson.OpenApi.Model.PropertyChange

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Property or nested property to which the change applies.  Nested properties are specified by paths; for example, - foo.bar - foo.arProp\\[\&quot;key val\&quot;\\] - foo.arProp\\[\&quot;key val\&quot;\\].baz  | 
**Op** | **PropertyChangeOpEnum** | Change operation for the property.  Valid values are: &lt;dl&gt; &lt;dt&gt;add&lt;/dt&gt; &lt;dd&gt;The property is a collection and the change inserts an element into the collection.&lt;/dd&gt; &lt;dt&gt;remove&lt;/dt&gt; &lt;dd&gt;The property is a collection and the change deletes an element from the collection.&lt;/dd&gt; &lt;dt&gt;assign&lt;/dt&gt; &lt;dd&gt;The change is a new value for the property.&lt;/dd&gt; &lt;dt&gt;indirectRemove&lt;/dt&gt; &lt;dd&gt;The property was removed because a containing property was removed or unset&lt;/dd&gt; &lt;/dl&gt;  | 
**Val** | [**Any**](Any.md) | New value for the property when \&quot;op\&quot; is either \&quot;add\&quot; or \&quot;assign\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

