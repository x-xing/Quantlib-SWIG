//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class MarkovFunctional : Gaussian1dModel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MarkovFunctional(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.MarkovFunctional_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MarkovFunctional obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MarkovFunctional() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_MarkovFunctional(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints, double digitalGap, double marketRateAccuracy, double lowerRateBound, double upperRateBound, int adjustments, DoubleVector smileMoneyCheckpoints) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_0(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints, digitalGap, marketRateAccuracy, lowerRateBound, upperRateBound, adjustments, DoubleVector.getCPtr(smileMoneyCheckpoints)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints, double digitalGap, double marketRateAccuracy, double lowerRateBound, double upperRateBound, int adjustments) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_1(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints, digitalGap, marketRateAccuracy, lowerRateBound, upperRateBound, adjustments), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints, double digitalGap, double marketRateAccuracy, double lowerRateBound, double upperRateBound) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_2(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints, digitalGap, marketRateAccuracy, lowerRateBound, upperRateBound), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints, double digitalGap, double marketRateAccuracy, double lowerRateBound) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_3(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints, digitalGap, marketRateAccuracy, lowerRateBound), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints, double digitalGap, double marketRateAccuracy) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_4(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints, digitalGap, marketRateAccuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints, double digitalGap) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_5(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints, digitalGap), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs, uint gaussHermitePoints) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_6(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs, gaussHermitePoints), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints, double yStdDevs) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_7(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints, yStdDevs), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase, uint yGridPoints) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_8(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase), yGridPoints), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MarkovFunctional(YieldTermStructureHandle termStructure, double reversion, DateVector volstepdates, DoubleVector volatilities, SwaptionVolatilityStructureHandle swaptionVol, DateVector swaptionExpiries, PeriodVector swaptionTenors, SwapIndex swapIndexBase) : this(NQuantLibcPINVOKE.new_MarkovFunctional__SWIG_9(YieldTermStructureHandle.getCPtr(termStructure), reversion, DateVector.getCPtr(volstepdates), DoubleVector.getCPtr(volatilities), SwaptionVolatilityStructureHandle.getCPtr(swaptionVol), DateVector.getCPtr(swaptionExpiries), PeriodVector.getCPtr(swaptionTenors), SwapIndex.getCPtr(swapIndexBase)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrate(CalibrationHelperVector helper, OptimizationMethod method, EndCriteria endCriteria, Constraint constraint, DoubleVector weights, BoolVector fixParameters) {
    NQuantLibcPINVOKE.MarkovFunctional_calibrate__SWIG_0(swigCPtr, CalibrationHelperVector.getCPtr(helper), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria), Constraint.getCPtr(constraint), DoubleVector.getCPtr(weights), BoolVector.getCPtr(fixParameters));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrate(CalibrationHelperVector helper, OptimizationMethod method, EndCriteria endCriteria, Constraint constraint, DoubleVector weights) {
    NQuantLibcPINVOKE.MarkovFunctional_calibrate__SWIG_1(swigCPtr, CalibrationHelperVector.getCPtr(helper), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria), Constraint.getCPtr(constraint), DoubleVector.getCPtr(weights));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrate(CalibrationHelperVector helper, OptimizationMethod method, EndCriteria endCriteria, Constraint constraint) {
    NQuantLibcPINVOKE.MarkovFunctional_calibrate__SWIG_2(swigCPtr, CalibrationHelperVector.getCPtr(helper), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria), Constraint.getCPtr(constraint));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrate(CalibrationHelperVector helper, OptimizationMethod method, EndCriteria endCriteria) {
    NQuantLibcPINVOKE.MarkovFunctional_calibrate__SWIG_3(swigCPtr, CalibrationHelperVector.getCPtr(helper), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public QlArray volatility() {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.MarkovFunctional_volatility(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly MarkovFunctionalSettings.Adjustments AdjustNone = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_AdjustNone_get();
  public static readonly MarkovFunctionalSettings.Adjustments AdjustDigitals = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_AdjustDigitals_get();
  public static readonly MarkovFunctionalSettings.Adjustments AdjustYts = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_AdjustYts_get();
  public static readonly MarkovFunctionalSettings.Adjustments ExtrapolatePayoffFlat = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_ExtrapolatePayoffFlat_get();
  public static readonly MarkovFunctionalSettings.Adjustments NoPayoffExtrapolation = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_NoPayoffExtrapolation_get();
  public static readonly MarkovFunctionalSettings.Adjustments KahaleSmile = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_KahaleSmile_get();
  public static readonly MarkovFunctionalSettings.Adjustments SmileExponentialExtrapolation = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_SmileExponentialExtrapolation_get();
  public static readonly MarkovFunctionalSettings.Adjustments KahaleInterpolation = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_KahaleInterpolation_get();
  public static readonly MarkovFunctionalSettings.Adjustments SmileDeleteArbitragePoints = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_SmileDeleteArbitragePoints_get();
  public static readonly MarkovFunctionalSettings.Adjustments SabrSmile = (MarkovFunctionalSettings.Adjustments)NQuantLibcPINVOKE.MarkovFunctional_SabrSmile_get();
}

}