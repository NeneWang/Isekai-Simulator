 using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 
 public class TriggerOverride : EventTrigger
 {
     public Button _button = null;
     public Button button { get { if (_button == null) { _button = Get(); } return _button; } }
     //find the button on the object
     private Button Get()
     {
         return GetComponent<Button>();
     }
     //override on pointer enter so it only gets called when button is interactable
     public override void OnPointerEnter(PointerEventData eventData)
     {
         if (!button.interactable)
             return;
         base.OnPointerEnter(eventData);
         Debug.Log("On Enter");
     }
 }