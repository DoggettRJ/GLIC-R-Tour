// From "Throwable : MonoBehaviour"

using System;
using System.Collections;

using UnityEngine;
using UnityEngine.Events;

using UnityEngine.Video;

using Valve.VR;
using Valve.VR.InteractionSystem;


//-------------------------------------------------------------------------
[RequireComponent(typeof(Interactable))]
// [RequireComponent(typeof(Rigidbody))]
public class RobotClickable : MonoBehaviour
{
    [SerializeField]
    //private GameObject doink;

    [HideInInspector]
    public Interactable interactable;

    public GameObject Robot;
    public GameObject Button;
    public GameObject Red;


    public Animator buttonAnim;
    public Animator robotAnim;
    public Animator HoloGuide;

    public Material robotButtonMaterial;

    public GameObject RobotButtonArrow;


    public GameObject robotButtonDummy;
   
    public GameObject ResetRobot;

    //Arrows
    public GameObject lightArrow;

  
    public GameObject BeginEXP;

    public GameObject BeginExperiment;

    public GameObject LowLight;
    public GameObject LowFPS;

    public GameObject MedLight;
    public GameObject MedFPS;

    public GameObject HiLight;
    public GameObject HiFPS;


    public GameObject H1L0;
    public GameObject H1L1;
    public GameObject H1L2;
    public GameObject H2L0L1;
    public GameObject H2L2;
    public GameObject H3All;


    public GameObject BlankScreen;
    public GameObject VideoOutputs;

    public GameObject RunRobotHint;

    public AudioSource sound;

    public GameObject Retry;

    /// /////////////////////////////
    void Start()
    {
        robotButtonMaterial = GetComponent<Renderer>().material;
        BlankScreen.SetActive(true);
    }

    private void Update()
    {
        if (Red.activeInHierarchy)
        {
            robotButtonMaterial.color = Color.red;


        }
    }
    /////////////////////////////////
   

    IEnumerator H1L0HoloOutput()
    {
        yield return new WaitForSeconds(6f);
        HoloGuide.Play("H1L0Start");
        robotAnim.Play("cancelRobot");
    }

    IEnumerator H1L0Output()
    {
        
            yield return new WaitForSeconds(6f);
            VideoOutputs.SetActive(true);
            BlankScreen.SetActive(false);
            H1L0.SetActive(true);
            yield return new WaitForSeconds(10f);
            VideoOutputs.SetActive(false);
            H1L0.SetActive(false);
            BlankScreen.SetActive(true);
          
            RunRobotHint.SetActive(false);
            robotButtonMaterial.color = Color.red;
        yield return new WaitForSeconds(2f);
        Retry.SetActive(true);
    }

    IEnumerator H1L1HoloOutput()
    {
        yield return new WaitForSeconds(6f);
        HoloGuide.Play("H1L1Start");
    }

    IEnumerator H1L1Output()
    {
       
            yield return new WaitForSeconds(6f);
            
            VideoOutputs.SetActive(true); 
            BlankScreen.SetActive(false);
            H1L1.SetActive(true);
            yield return new WaitForSeconds(10f);
            VideoOutputs.SetActive(false);
            H1L1.SetActive(false);
            BlankScreen.SetActive(true);
            robotButtonMaterial.color = Color.red;
            
            RunRobotHint.SetActive(false);
        yield return new WaitForSeconds(2f);
        Retry.SetActive(true);
    }

    IEnumerator H1L2HoloOutput()
    {
        yield return new WaitForSeconds(6f);
        HoloGuide.Play("H1L2Start");
    }

    IEnumerator H1L2Output()
    {

        yield return new WaitForSeconds(6f);
        VideoOutputs.SetActive(true);
        BlankScreen.SetActive(false);
        H1L2.SetActive(true);
        yield return new WaitForSeconds(10f);
        VideoOutputs.SetActive(false);
        H1L2.SetActive(false);
        BlankScreen.SetActive(true);
        robotButtonMaterial.color = Color.red;
       
        RunRobotHint.SetActive(false);
        yield return new WaitForSeconds(2f);
        Retry.SetActive(true);
    }

    IEnumerator H2L0L1HoloOutput()
    {
        yield return new WaitForSeconds(6f);
        HoloGuide.Play("H2L0Start");
    }

    IEnumerator H2L0L1Output()
    {

        yield return new WaitForSeconds(6f);
        VideoOutputs.SetActive(true);
        BlankScreen.SetActive(false);
        H2L0L1.SetActive(true);
        yield return new WaitForSeconds(10f);
        VideoOutputs.SetActive(false);
        H2L0L1.SetActive(false);
        BlankScreen.SetActive(true);
        robotButtonMaterial.color = Color.red;
        
        RunRobotHint.SetActive(false);
        yield return new WaitForSeconds(2f);
        Retry.SetActive(true);
    }

    IEnumerator H2L2HoloOutput()
    {
        yield return new WaitForSeconds(6f);
        HoloGuide.Play("H2L2Start");
    }

    IEnumerator H2L2Output()
    {

        yield return new WaitForSeconds(6f);
        VideoOutputs.SetActive(true);
        BlankScreen.SetActive(false);
        H2L2.SetActive(true);
        yield return new WaitForSeconds(10f);
        VideoOutputs.SetActive(false);
        H2L2.SetActive(false);
        BlankScreen.SetActive(true);
        robotButtonMaterial.color = Color.red;
       
        RunRobotHint.SetActive(false);
        yield return new WaitForSeconds(2f);
        Retry.SetActive(true);
    }

    IEnumerator H3AllHoloOutput()
    {
        yield return new WaitForSeconds(6f);
        HoloGuide.Play("H3AllStart");
    }

    IEnumerator H3AllOutput()
    {

        yield return new WaitForSeconds(6f);
        VideoOutputs.SetActive(true);
        BlankScreen.SetActive(false);
        H3All.SetActive(true);
        yield return new WaitForSeconds(10f);
        VideoOutputs.SetActive(false);
        H3All.SetActive(false);
        BlankScreen.SetActive(true);
        robotButtonMaterial.color = Color.red;
      
        RunRobotHint.SetActive(false);
        yield return new WaitForSeconds(2f);
        Retry.SetActive(true);
    }



    /// /////////////////////////////

 

    //-------------------------------------------------
    protected virtual void Awake()
    {
        interactable = GetComponent<Interactable>();
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverBegin(Hand hand)
    {
       // Debug.Log($"OnHandHoverBegin(Hand hand): { gameObject.name }");
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverEnd(Hand hand)
    {
       // Debug.Log($"OnHandHoverEnd(Hand hand): { gameObject.name }");
        hand.HideGrabHint();
    }


    //-------------------------------------------------
    protected virtual void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();

        if (startingGrabType != GrabTypes.None)
        {
            if (startingGrabType == GrabTypes.Pinch)
            {
                if (RunRobotHint.activeInHierarchy) {

                    sound.Play();

                    buttonAnim.Play("robotButtonPress");
                    robotAnim.Play("mugGrab");
                    robotButtonMaterial.color = Color.green;

                    Red.SetActive(false);

                    RobotButtonArrow.SetActive(false);

                    if (LowLight.activeInHierarchy & LowFPS.activeInHierarchy)
                    {
                        StartCoroutine(H1L0Output());
                        StartCoroutine(H1L0HoloOutput());
                    }

                    if (MedLight.activeInHierarchy & LowFPS.activeInHierarchy)
                    {
                        StartCoroutine(H1L1Output());
                        StartCoroutine(H1L1HoloOutput());

                    }

                    if (HiLight.activeInHierarchy & LowFPS.activeInHierarchy)
                    {
                        StartCoroutine(H1L2Output());
                        StartCoroutine(H1L2HoloOutput());

                    }

                    if (LowLight.activeInHierarchy & MedFPS.activeInHierarchy || MedLight.activeInHierarchy & MedFPS.activeInHierarchy)
                    {
                        StartCoroutine(H2L0L1Output());
                        StartCoroutine(H2L0L1HoloOutput());

                    }

                    if (HiLight.activeInHierarchy & MedFPS.activeInHierarchy)
                    {
                        StartCoroutine(H2L2Output());
                        StartCoroutine(H2L2HoloOutput());

                    }

                    if (LowLight.activeInHierarchy & HiFPS.activeInHierarchy || MedLight.activeInHierarchy & HiFPS.activeInHierarchy || HiLight.activeInHierarchy & HiFPS.activeInHierarchy)
                    {
                        StartCoroutine(H3AllOutput());
                        StartCoroutine(H3AllHoloOutput());

                    }
                    }
         }
    }

            switch (startingGrabType)
            {
                case GrabTypes.Pinch:
                    // do pinch stuff
                    break;
                case GrabTypes.Trigger:
                    // do trigger stuff
                    break;
                default:
                    Debug.Log("Debug is teh workings now?");
                    break;
            }


            hand.HideGrabHint();
        }
    }

   








/*
    public class Throwable : MonoBehaviour
    {
        [EnumFlags]
        [Tooltip("The flags used to attach this object to the hand.")]
        public Hand.AttachmentFlags attachmentFlags = Hand.AttachmentFlags.ParentToHand | Hand.AttachmentFlags.DetachFromOtherHand | Hand.AttachmentFlags.TurnOnKinematic;

        [Tooltip("The local point which acts as a positional and rotational offset to use while held")]
        public Transform attachmentOffset;

        [Tooltip("How fast must this object be moving to attach due to a trigger hold instead of a trigger press? (-1 to disable)")]
        public float catchingSpeedThreshold = -1;

        public ReleaseStyle releaseVelocityStyle = ReleaseStyle.GetFromHand;

        [Tooltip("The time offset used when releasing the object with the RawFromHand option")]
        public float releaseVelocityTimeOffset = -0.011f;

        public float scaleReleaseVelocity = 1.1f;

        [Tooltip("When detaching the object, should it return to its original parent?")]
        public bool restoreOriginalParent = false;



        protected VelocityEstimator velocityEstimator;
        protected bool attached = false;
        protected float attachTime;
        protected Vector3 attachPosition;
        protected Quaternion attachRotation;
        protected Transform attachEaseInTransform;

        public UnityEvent onPickUp;
        public UnityEvent onDetachFromHand;
        public UnityEvent<Hand> onHeldUpdate;


        protected RigidbodyInterpolation hadInterpolation = RigidbodyInterpolation.None;

        protected new Rigidbody rigidbody;

        [HideInInspector]
        public Interactable interactable;


        //-------------------------------------------------
        protected virtual void Awake()
        {
            velocityEstimator = GetComponent<VelocityEstimator>();
            interactable = GetComponent<Interactable>();



            rigidbody = GetComponent<Rigidbody>();
            rigidbody.maxAngularVelocity = 50.0f;


            if (attachmentOffset != null)
            {
                // remove?
                //interactable.handFollowTransform = attachmentOffset;
            }

        }


        //-------------------------------------------------
        protected virtual void OnHandHoverBegin(Hand hand)
        {
            bool showHint = false;

            // "Catch" the throwable by holding down the interaction button instead of pressing it.
            // Only do this if the throwable is moving faster than the prescribed threshold speed,
            // and if it isn't attached to another hand
            if (!attached && catchingSpeedThreshold != -1)
            {
                float catchingThreshold = catchingSpeedThreshold * SteamVR_Utils.GetLossyScale(Player.instance.trackingOriginTransform);

                GrabTypes bestGrabType = hand.GetBestGrabbingType();

                if (bestGrabType != GrabTypes.None)
                {
                    if (rigidbody.velocity.magnitude >= catchingThreshold)
                    {
                        hand.AttachObject(gameObject, bestGrabType, attachmentFlags);
                        showHint = false;
                    }
                }
            }

            if (showHint)
            {
                hand.ShowGrabHint();
            }
        }


        //-------------------------------------------------
        protected virtual void OnHandHoverEnd(Hand hand)
        {
            hand.HideGrabHint();
        }


        //-------------------------------------------------
        protected virtual void HandHoverUpdate(Hand hand)
        {
            GrabTypes startingGrabType = hand.GetGrabStarting();

            if (startingGrabType != GrabTypes.None)
            {
                hand.AttachObject(gameObject, startingGrabType, attachmentFlags, attachmentOffset);
                hand.HideGrabHint();
            }
        }

        //-------------------------------------------------
        protected virtual void OnAttachedToHand(Hand hand)
        {
            //Debug.Log("<b>[SteamVR Interaction]</b> Pickup: " + hand.GetGrabStarting().ToString());

            hadInterpolation = this.rigidbody.interpolation;

            attached = true;

            onPickUp.Invoke();

            hand.HoverLock(null);

            rigidbody.interpolation = RigidbodyInterpolation.None;

            velocityEstimator.BeginEstimatingVelocity();

            attachTime = Time.time;
            attachPosition = transform.position;
            attachRotation = transform.rotation;

        }


        //-------------------------------------------------
        protected virtual void OnDetachedFromHand(Hand hand)
        {
            attached = false;

            onDetachFromHand.Invoke();

            hand.HoverUnlock(null);

            rigidbody.interpolation = hadInterpolation;

            Vector3 velocity;
            Vector3 angularVelocity;

            GetReleaseVelocities(hand, out velocity, out angularVelocity);

            rigidbody.velocity = velocity;
            rigidbody.angularVelocity = angularVelocity;
        }


        public virtual void GetReleaseVelocities(Hand hand, out Vector3 velocity, out Vector3 angularVelocity)
        {
            if (hand.noSteamVRFallbackCamera && releaseVelocityStyle != ReleaseStyle.NoChange)
                releaseVelocityStyle = ReleaseStyle.ShortEstimation; // only type that works with fallback hand is short estimation.

            switch (releaseVelocityStyle)
            {
                case ReleaseStyle.ShortEstimation:
                    velocityEstimator.FinishEstimatingVelocity();
                    velocity = velocityEstimator.GetVelocityEstimate();
                    angularVelocity = velocityEstimator.GetAngularVelocityEstimate();
                    break;
                case ReleaseStyle.AdvancedEstimation:
                    hand.GetEstimatedPeakVelocities(out velocity, out angularVelocity);
                    break;
                case ReleaseStyle.GetFromHand:
                    velocity = hand.GetTrackedObjectVelocity(releaseVelocityTimeOffset);
                    angularVelocity = hand.GetTrackedObjectAngularVelocity(releaseVelocityTimeOffset);
                    break;
                default:
                case ReleaseStyle.NoChange:
                    velocity = rigidbody.velocity;
                    angularVelocity = rigidbody.angularVelocity;
                    break;
            }

            if (releaseVelocityStyle != ReleaseStyle.NoChange)
                velocity *= scaleReleaseVelocity;
        }

        //-------------------------------------------------
        protected virtual void HandAttachedUpdate(Hand hand)
        {


            if (hand.IsGrabEnding(this.gameObject))
            {
                hand.DetachObject(gameObject, restoreOriginalParent);

                // Uncomment to detach ourselves late in the frame.
                // This is so that any vehicles the player is attached to
                // have a chance to finish updating themselves.
                // If we detach now, our position could be behind what it
                // will be at the end of the frame, and the object may appear
                // to teleport behind the hand when the player releases it.
                //StartCoroutine( LateDetach( hand ) );
            }

            if (onHeldUpdate != null)
                onHeldUpdate.Invoke(hand);
        }


        //-------------------------------------------------
        protected virtual IEnumerator LateDetach(Hand hand)
        {
            yield return new WaitForEndOfFrame();

            hand.DetachObject(gameObject, restoreOriginalParent);
        }


        //-------------------------------------------------
        protected virtual void OnHandFocusAcquired(Hand hand)
        {
            gameObject.SetActive(true);
            velocityEstimator.BeginEstimatingVelocity();
        }


        //-------------------------------------------------
        protected virtual void OnHandFocusLost(Hand hand)
        {
            gameObject.SetActive(false);
            velocityEstimator.FinishEstimatingVelocity();
        }
    }

    public enum ReleaseStyle
    {
        NoChange,
        GetFromHand,
        ShortEstimation,
        AdvancedEstimation,
    }
*/