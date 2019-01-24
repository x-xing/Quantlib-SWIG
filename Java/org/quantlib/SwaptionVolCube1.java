/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class SwaptionVolCube1 extends SwaptionVolatilityStructure {
  private transient long swigCPtr;

  protected SwaptionVolCube1(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.SwaptionVolCube1_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(SwaptionVolCube1 obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_SwaptionVolCube1(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public SwaptionVolCube1(SwaptionVolatilityStructureHandle atmVolStructure, PeriodVector optionTenors, PeriodVector swapTenors, DoubleVector strikeSpreads, QuoteHandleVectorVector volSpreads, SwapIndex swapIndexBase, SwapIndex shortSwapIndexBase, boolean vegaWeightedSmileFit, QuoteHandleVectorVector parametersGuess, BoolVector isParameterFixed, boolean isAtmCalibrated, SWIGTYPE_p_boost__shared_ptrT_EndCriteria_t endCriteria, double maxErrorTolerance, SWIGTYPE_p_boost__shared_ptrT_OptimizationMethod_t optMethod) {
    this(QuantLibJNI.new_SwaptionVolCube1__SWIG_0(SwaptionVolatilityStructureHandle.getCPtr(atmVolStructure), atmVolStructure, PeriodVector.getCPtr(optionTenors), optionTenors, PeriodVector.getCPtr(swapTenors), swapTenors, DoubleVector.getCPtr(strikeSpreads), strikeSpreads, QuoteHandleVectorVector.getCPtr(volSpreads), volSpreads, SwapIndex.getCPtr(swapIndexBase), swapIndexBase, SwapIndex.getCPtr(shortSwapIndexBase), shortSwapIndexBase, vegaWeightedSmileFit, QuoteHandleVectorVector.getCPtr(parametersGuess), parametersGuess, BoolVector.getCPtr(isParameterFixed), isParameterFixed, isAtmCalibrated, SWIGTYPE_p_boost__shared_ptrT_EndCriteria_t.getCPtr(endCriteria), maxErrorTolerance, SWIGTYPE_p_boost__shared_ptrT_OptimizationMethod_t.getCPtr(optMethod)), true);
  }

  public SwaptionVolCube1(SwaptionVolatilityStructureHandle atmVolStructure, PeriodVector optionTenors, PeriodVector swapTenors, DoubleVector strikeSpreads, QuoteHandleVectorVector volSpreads, SwapIndex swapIndexBase, SwapIndex shortSwapIndexBase, boolean vegaWeightedSmileFit, QuoteHandleVectorVector parametersGuess, BoolVector isParameterFixed, boolean isAtmCalibrated, SWIGTYPE_p_boost__shared_ptrT_EndCriteria_t endCriteria, double maxErrorTolerance) {
    this(QuantLibJNI.new_SwaptionVolCube1__SWIG_1(SwaptionVolatilityStructureHandle.getCPtr(atmVolStructure), atmVolStructure, PeriodVector.getCPtr(optionTenors), optionTenors, PeriodVector.getCPtr(swapTenors), swapTenors, DoubleVector.getCPtr(strikeSpreads), strikeSpreads, QuoteHandleVectorVector.getCPtr(volSpreads), volSpreads, SwapIndex.getCPtr(swapIndexBase), swapIndexBase, SwapIndex.getCPtr(shortSwapIndexBase), shortSwapIndexBase, vegaWeightedSmileFit, QuoteHandleVectorVector.getCPtr(parametersGuess), parametersGuess, BoolVector.getCPtr(isParameterFixed), isParameterFixed, isAtmCalibrated, SWIGTYPE_p_boost__shared_ptrT_EndCriteria_t.getCPtr(endCriteria), maxErrorTolerance), true);
  }

  public SwaptionVolCube1(SwaptionVolatilityStructureHandle atmVolStructure, PeriodVector optionTenors, PeriodVector swapTenors, DoubleVector strikeSpreads, QuoteHandleVectorVector volSpreads, SwapIndex swapIndexBase, SwapIndex shortSwapIndexBase, boolean vegaWeightedSmileFit, QuoteHandleVectorVector parametersGuess, BoolVector isParameterFixed, boolean isAtmCalibrated, SWIGTYPE_p_boost__shared_ptrT_EndCriteria_t endCriteria) {
    this(QuantLibJNI.new_SwaptionVolCube1__SWIG_2(SwaptionVolatilityStructureHandle.getCPtr(atmVolStructure), atmVolStructure, PeriodVector.getCPtr(optionTenors), optionTenors, PeriodVector.getCPtr(swapTenors), swapTenors, DoubleVector.getCPtr(strikeSpreads), strikeSpreads, QuoteHandleVectorVector.getCPtr(volSpreads), volSpreads, SwapIndex.getCPtr(swapIndexBase), swapIndexBase, SwapIndex.getCPtr(shortSwapIndexBase), shortSwapIndexBase, vegaWeightedSmileFit, QuoteHandleVectorVector.getCPtr(parametersGuess), parametersGuess, BoolVector.getCPtr(isParameterFixed), isParameterFixed, isAtmCalibrated, SWIGTYPE_p_boost__shared_ptrT_EndCriteria_t.getCPtr(endCriteria)), true);
  }

  public SwaptionVolCube1(SwaptionVolatilityStructureHandle atmVolStructure, PeriodVector optionTenors, PeriodVector swapTenors, DoubleVector strikeSpreads, QuoteHandleVectorVector volSpreads, SwapIndex swapIndexBase, SwapIndex shortSwapIndexBase, boolean vegaWeightedSmileFit, QuoteHandleVectorVector parametersGuess, BoolVector isParameterFixed, boolean isAtmCalibrated) {
    this(QuantLibJNI.new_SwaptionVolCube1__SWIG_3(SwaptionVolatilityStructureHandle.getCPtr(atmVolStructure), atmVolStructure, PeriodVector.getCPtr(optionTenors), optionTenors, PeriodVector.getCPtr(swapTenors), swapTenors, DoubleVector.getCPtr(strikeSpreads), strikeSpreads, QuoteHandleVectorVector.getCPtr(volSpreads), volSpreads, SwapIndex.getCPtr(swapIndexBase), swapIndexBase, SwapIndex.getCPtr(shortSwapIndexBase), shortSwapIndexBase, vegaWeightedSmileFit, QuoteHandleVectorVector.getCPtr(parametersGuess), parametersGuess, BoolVector.getCPtr(isParameterFixed), isParameterFixed, isAtmCalibrated), true);
  }

  public Matrix sparseSabrParameters() {
    return new Matrix(QuantLibJNI.SwaptionVolCube1_sparseSabrParameters(swigCPtr, this), true);
  }

  public Matrix denseSabrParameters() {
    return new Matrix(QuantLibJNI.SwaptionVolCube1_denseSabrParameters(swigCPtr, this), true);
  }

  public Matrix marketVolCube() {
    return new Matrix(QuantLibJNI.SwaptionVolCube1_marketVolCube(swigCPtr, this), true);
  }

  public Matrix volCubeAtmCalibrated() {
    return new Matrix(QuantLibJNI.SwaptionVolCube1_volCubeAtmCalibrated(swigCPtr, this), true);
  }

}