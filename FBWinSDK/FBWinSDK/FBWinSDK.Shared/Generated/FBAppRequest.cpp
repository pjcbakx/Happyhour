

//------------------------------------------------------------------------------
//
// Copyright (c) 2015 Microsoft Corporation. All rights reserved.
//
// This code is licensed under the MIT License (MIT).
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//------------------------------------------------------------------------------




#include "pch.h"
#include "FBAppRequest.h"

using namespace Facebook;
using namespace Facebook::Graph;
using namespace Platform;
using namespace Windows::Data::Json;
using namespace Windows::Foundation::Collections;

FBAppRequest::FBAppRequest(
    ) :
    _action_type(nullptr),
    _created_time(nullptr),
    _data(nullptr),
    _from(nullptr),
    _id(nullptr),
    _message(nullptr),
    _to(nullptr)

{
    ;
}


String^ FBAppRequest::ActionType::get()
{
    return _action_type;
}
void FBAppRequest::ActionType::set(String^ value)
{
    _action_type = value;

}


String^ FBAppRequest::CreatedTime::get()
{
    return _created_time;
}
void FBAppRequest::CreatedTime::set(String^ value)
{
    _created_time = value;

}


String^ FBAppRequest::Data::get()
{
    return _data;
}
void FBAppRequest::Data::set(String^ value)
{
    _data = value;

}


FBUser^ FBAppRequest::From::get()
{
    return _from;
}
void FBAppRequest::From::set(FBUser^ value)
{
    _from = value;

}


String^ FBAppRequest::Id::get()
{
    return _id;
}
void FBAppRequest::Id::set(String^ value)
{
    _id = value;

}


String^ FBAppRequest::Message::get()
{
    return _message;
}
void FBAppRequest::Message::set(String^ value)
{
    _message = value;

}


FBUser^ FBAppRequest::To::get()
{
    return _to;
}
void FBAppRequest::To::set(FBUser^ value)
{
    _to = value;

}


Object^ FBAppRequest::FromJson(
    String^ JsonText 
    )
{
    FBAppRequest^ result = ref new FBAppRequest;
    int found = 0;
    JsonValue^ val = nullptr;

    if (JsonValue::TryParse(JsonText, &val))
    {
        if (val->ValueType == JsonValueType::Object)
        {
            JsonObject^ obj = val->GetObject();
            IIterator<IKeyValuePair<String^, IJsonValue^>^>^ it = nullptr;
            for (it = obj->First(); it->HasCurrent; it->MoveNext())
            {
                String^ key = it->Current->Key;

                if  (!String::CompareOrdinal(key, L"action_type"))
                {

                    found++;
                    result->ActionType = it->Current->Value->GetString();

                }

                else if (!String::CompareOrdinal(key, L"created_time"))
                {

                    found++;
                    result->CreatedTime = it->Current->Value->GetString();

                }

                else if (!String::CompareOrdinal(key, L"data"))
                {

                    found++;
                    result->Data = it->Current->Value->GetString();

                }

                else if (!String::CompareOrdinal(key, L"from"))
                {

                    found++;
                    result->From = static_cast<FBUser^>(FBUser::FromJson(it->Current->Value->Stringify()));

                }

                else if (!String::CompareOrdinal(key, L"id"))
                {

                    found++;
                    result->Id = it->Current->Value->GetString();

                }

                else if (!String::CompareOrdinal(key, L"message"))
                {

                    found++;
                    result->Message = it->Current->Value->GetString();

                }

                else if (!String::CompareOrdinal(key, L"to"))
                {

                    found++;
                    result->To = static_cast<FBUser^>(FBUser::FromJson(it->Current->Value->Stringify()));

                }

            }

            if (!found)
            {
                // No field names matched any known properties for this class.  
                // Even if it *is* an object of our type, it's not useful.
                result = nullptr;
            }
        }
    }
    return result;
}




